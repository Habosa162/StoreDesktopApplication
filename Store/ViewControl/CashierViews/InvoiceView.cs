using Microsoft.EntityFrameworkCore;
using Store.Models.Context;
using Store.Models.InvoiceModels;
using Store.ViewControl.CashierViews;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text;
namespace Store.ViewControl
{
    public partial class InvoiceView : Form
    {
        Invoice _invoice = SingletonInvoice.invoice;

        PlaystationStoreContext _context = new PlaystationStoreContext();

        public InvoiceView()
        {
            InitializeComponent();
        }

        void LoadInvoiceItems()
        {
            if (_invoice?.invoiceItems != null)
            {
                var invoiceItems = _context.InvoiceItems
                    .Where(i => i.InvoiceId == _invoice.InvoiceId)
                    .Include(i => i.Product)
                    .Select(i => new
                    {
                        Quantity = i.ItemQuantity,
                        Price = i.InvoiceItemPrice,
                        Total = i.InvoiceItemTotal,
                        Product = i.Product.ProductName ?? "N/A",
                        Device_Maintenance_Description = i.DeviceMaintenance.Description ?? "N/A"
                    }).ToList();

                dataGridView1.DataSource = invoiceItems;

            }
        }

        public void checkIsActiveCheckout()
        {
            bool hasInvoiceItems = _invoice.invoiceItems.Count > 0;
            bool hasCustomerPhoneNumber = !string.IsNullOrEmpty(_invoice.CustomerPhoneNumber);
            CheckOutBtn.Visible = hasInvoiceItems && hasCustomerPhoneNumber;
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {
            LoadInvoiceItems();
            checkIsActiveCheckout();
        }



        private void button4_Click(object sender, EventArgs e)
        {

            ProductsView productsView = new ProductsView();
            productsView.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenanceInvoiceItem deviceMaintenance = new MaintenanceInvoiceItem();
            deviceMaintenance.Show();
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            CustomerInfoView customerInfoView = new CustomerInfoView();
            customerInfoView.Show();
            this.Close();
        }
     


        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            try
            {
                //  invoice items
                if (_invoice == null || _invoice.invoiceItems == null || !_invoice.invoiceItems.Any())
                {
                    MessageBox.Show("No items in the invoice to check out.");
                    return;
                }

                double totalAmount = _invoice.invoiceItems.Sum(i => i.InvoiceItemTotal);

           
                _invoice.IsCheckOut = true;
                _invoice.CheckOutDate = DateTime.Now;
                _invoice.TotalAmount = totalAmount;

                foreach (var item in _invoice.invoiceItems)
                {
                    if (item.Product != null)
                    {
                        if (item.Product.StockQuantity - item.ItemQuantity >= 0)
                        {
                            item.Product.StockQuantity -= item.ItemQuantity;
                        }
                        else
                        {
                            MessageBox.Show($"Not enough stock for {item.Product.ProductName}.Available stock: {item.Product.StockQuantity}");
                            return;
                        }
                    }
                    else if (item.DeviceMaintenance != null)
                    {
                        item.DeviceMaintenance.isFixed = true;
                    }
                }

                _context.Invoices.Update(_invoice);
                _context.SaveChanges();

                string invoiceSummary = GenerateInvoiceSummary(_invoice);

                try
                {

                    using (FileStream fs = new FileStream(@$"E:\I T I\EF\Project\Store\invoices\invoice{_invoice.InvoiceId}.pdf", FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        Document document = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(document, fs);
                        document.Open();


                        // Add logo
                        string logoPath = @"E:\I T I\EF\Project\Store\imgs\logo.png";
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                        //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources);
                        logo.ScaleToFit(140f, 120f);
                        logo.Alignment = Element.ALIGN_RIGHT;
                        document.Add(logo);


                        // Add styled content
                        iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                        Paragraph title = new Paragraph("Joystick Gaming Invoice", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        //added pdf title
                        document.Add(title);

                        iTextSharp.text.Font contentFont = FontFactory.GetFont(FontFactory.TIMES, 14, BaseColor.BLACK);

                        Paragraph content = new Paragraph(invoiceSummary, contentFont);

                        content.SpacingBefore = 20f;
                        content.SpacingAfter = 20f;
                        //added pdf content
                        document.Add(content);

                        document.Close();
                       
                    }
                    MessageBox.Show("PDF generated successfully!");
                    MessageBox.Show(invoiceSummary);
                    //open the document after genrate

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


                ////
                SingletonInvoice.ClearInvoice();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during checkout: {ex.Message}");
            }
        }




        private string GenerateInvoiceSummary(Invoice invoice)
        {
            var summary = new StringBuilder();

            // Loop through each invoice item and add product or maintenance information
            foreach (var it in invoice.invoiceItems)
            {
                if (it.Product != null)
                {
                    summary.AppendLine($"Product Name : {it.Product.ProductName}");
                    summary.AppendLine($"Product Quantity : {it.ItemQuantity}");

                }

                if (it.DeviceMaintenance != null)
                {
                    summary.AppendLine($"Maintenance Description : {it.DeviceMaintenance.Description}");
                    summary.AppendLine($"Device Serial Number : {it.DeviceMaintenance.DeviceSerialNo}");
                }

                summary.AppendLine($"Value : {it.InvoiceItemPrice:C}\n");
            }

            // Add invoice header and footer information
            summary.AppendLine($"\n\n\nInvoice #{invoice.InvoiceId}");
            summary.AppendLine($"Checked Out On : {invoice.CheckOutDate:yyyy-MM-dd}");
            summary.AppendLine($"Total Amount : {invoice.TotalAmount:C}");
            summary.AppendLine($"Number of Items : {invoice.invoiceItems.Count}\n");
            summary.AppendLine($"Branch : {CurrentUser.Instance.Branch}");
            summary.AppendLine($"Username : {CurrentUser.Instance.UserName}");
            summary.AppendLine($"Customer Customer Name : {_context.Customers.FirstOrDefault(c=>c.phoneNo==invoice.CustomerPhoneNumber).Name}");
            summary.AppendLine($"Customer Phone Number : {invoice.CustomerPhoneNumber}\n");
            
            summary.AppendLine("Thank you for your purchase!");
            return summary.ToString();
        }





    }
}
