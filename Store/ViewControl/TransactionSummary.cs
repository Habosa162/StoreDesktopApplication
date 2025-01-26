using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using Store.Models.Context;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Store.ViewControl
{
    internal class TransactionSummary
    {
        private PlaystationStoreContext _context = new PlaystationStoreContext();

        public double TotalExpenses { get; set; }
        public double TotalPurchases { get; set; }
        public double TotalIncome { get; set; }

        public TransactionSummary CalculateDailySummary()
        {
            var startOfDay = DateTime.Today;
            var now = DateTime.Now;

            var transactions = _context.Transactions
                .Where(t => t.Date >= startOfDay && t.Date <= now)
                .GroupBy(t => t.TransactionTypeID)
                .Select(g => new
                {
                    TransactionTypeID = g.Key,
                    TotalValue = g.Sum(t => t.value)
                }).ToList();

            var invoices = _context.Invoices
                .Where(i => i.Date >= startOfDay && i.Date <= now)
                .Sum(i => i.TotalAmount);

            var summary = new TransactionSummary();

            foreach (var transaction in transactions)
            {
                switch (transaction.TransactionTypeID)
                {
                    case 1:
                        summary.TotalExpenses += transaction.TotalValue;
                        break;
                    case 2:
                        summary.TotalPurchases += transaction.TotalValue;
                        break;
                    case 3:
                        summary.TotalIncome += transaction.TotalValue;
                        break;
                }
            }

            summary.TotalIncome += invoices;
            return summary;
        }

        public void GenerateTransactionSummaryPDF(string filePath)
        {
            var startOfDay = DateTime.Today;
            var now = DateTime.Now;

            var transactions = _context.Transactions
                .Where(t => t.Date >= startOfDay && t.Date <= now)
                .Include(t => t.TransactionType)
                .ToList();

            var invoices = _context.Invoices
                .Where(i => i.Date >= startOfDay && i.Date <= now)
                .ToList();

            var summary = CalculateDailySummary();

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            var title = new Paragraph("Daily Transaction Summary")
            {
                Alignment = Element.ALIGN_CENTER
            };
            doc.Add(title);

            doc.Add(new Paragraph($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}"));

            doc.Add(new Paragraph("Transactions:"));
            foreach (var transaction in transactions)
            {
                doc.Add(new Paragraph($"ID: {transaction.Id}, Description: {transaction.Description}, Date: {transaction.Date:yyyy-MM-dd HH:mm:ss}, Value: {transaction.value:C}, Type: {transaction.TransactionType.type}"));
            }

            doc.Add(new Paragraph("Invoices:"));
            foreach (var invoice in invoices)
            {
                doc.Add(new Paragraph($"ID: {invoice.InvoiceId}, Date: {invoice.Date:yyyy-MM-dd HH:mm:ss}, Total Amount: {invoice.TotalAmount:C}"));
            }

            doc.Add(new Paragraph($"Total Expenses: {summary.TotalExpenses:C}"));
            doc.Add(new Paragraph($"Total Purchases: {summary.TotalPurchases:C}"));
            doc.Add(new Paragraph($"Total Income: {summary.TotalIncome:C}"));

            doc.Close();
        }
    }

 
}
