using Boomkwekerij.Models;
using Boomkwekerij.Models.Conversion;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Reporting
{
	public class Factuur
	{
		public Factuur()
		{

		}

		public void Maak(Bestelling bestelling, string bedrijfsnaam, string straat, string postcode, string plaats, string telefoonnummer, string faxnummer, string mobiel, string email, string iban, string btwNummer, string kvkNummer, string filepath)
		{

			FileStream fileStream = new FileStream((string)filepath,
													FileMode.Create,
													FileAccess.Write,
													FileShare.None);

			Document doc = new Document();
			PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);
			doc.Open();

			//Title


			//Company Address

			PdfPTable companyInfoTable = new PdfPTable(2);
			companyInfoTable.WidthPercentage = 100;
			companyInfoTable.AddCell(getImageCell(@"C:\Users\Ferry\Dropbox\Visual Studio\Git Projects\Boomkwekerij\Boomkwekerij\Boomkwekerij\logo.jpg", PdfPCell.ALIGN_LEFT));
			companyInfoTable.AddCell(getCell(bedrijfsnaam+"\n"+straat+"\n"+postcode+"  "+plaats +"\nTelefoon: "+telefoonnummer+"\nFax: "+faxnummer+"\nMobiel: "+mobiel+"\n Email: "+email+"\nIBAN: "+iban+"\nBTW nr: "+btwNummer+"\nKVK nr: "+kvkNummer, PdfPCell.ALIGN_RIGHT));
			doc.Add(companyInfoTable);

			//Customer Details
			PdfPTable customerInfoTable = new PdfPTable(1);
			customerInfoTable.AddCell(getCell("Uw gegevens:",0));
			customerInfoTable.AddCell(getCell(bestelling.Klant.Naam, 0));
			customerInfoTable.AddCell(getCell(bestelling.Klant.Adres, 0));
			customerInfoTable.AddCell(getCell(bestelling.Klant.Postcode, 0));
			customerInfoTable.AddCell(getCell(bestelling.Klant.Plaats, 0));
			customerInfoTable.AddCell(getCell(bestelling.Klant.Email, 0));
			customerInfoTable.AddCell(getCell(bestelling.Klant.Telefoonnummer, 0));

			doc.Add(customerInfoTable);

			Paragraph title = new Paragraph("Factuurnummer: " + bestelling.Id);
			title.Alignment = 0;

			Paragraph date = new Paragraph("Factuurdatum: " + bestelling.Factuurdatum.Value.ToShortDateString());
			date.Alignment = 0;
			doc.Add(title);
			doc.Add(date);
			Paragraph separator = new Paragraph("_____________________________________________________________________________      ");
			separator.SpacingAfter = 5.5f;
			doc.Add(separator);

			//produce table and set its props, widths are fractions
			PdfPTable productTable = new PdfPTable(7);
			productTable.WidthPercentage = 100;
			float[] widths = new float[] { 175,200,75,100,80,80,80 };
			productTable.SetWidths(widths);

			//Add Headers
			productTable.AddCell(HeaderCell("Artikelomschrijving"));
			productTable.AddCell(HeaderCell("Omschrijving"));
			productTable.AddCell(HeaderCell("Jaren"));
			productTable.AddCell(HeaderCell("Maat"));
			productTable.AddCell(HeaderCell("Prijs/s"));
			productTable.AddCell(HeaderCell("Aantal"));
			productTable.AddCell(HeaderCell("Totaal"));

			//Add the data from individual items
			foreach (Bestelregel bestelregel in bestelling.Bestelregels)
			{
				productTable.AddCell(productCell(bestelregel.Plant.Naam));
				productTable.AddCell(productCell(bestelregel.Plant.Opmerking)); 
				productTable.AddCell(productCell(bestelregel.Plant.Jaren()));
				productTable.AddCell(productCell(EnumDescriptionConverter.GetDescriptionFromEnum(bestelregel.Plant.PlantGrootte)));
				productTable.AddCell(productCell(bestelregel.GetPrijsPerStuk().ToString()));
				productTable.AddCell(productCell(bestelregel.Aantal.ToString()));
				productTable.AddCell(productCell(bestelregel.GetBestelregelPrijs().ToString()));
			}
			doc.Add(productTable);
			doc.Add(separator);

			PdfPTable subtotalTable = new PdfPTable(5);
			subtotalTable.WidthPercentage = 100;
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(getCell("Subtotaal:",2));
			subtotalTable.AddCell(getCell(bestelling.FormattedPrijsEx(),2));
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(getCell("Toeslag ("+bestelling.ToeslagPercentage+"):",2));
			subtotalTable.AddCell(getCell(bestelling.FormattedToeslagBedrag(),2));
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(BlankCell());
			subtotalTable.AddCell(getCell("Totaal:",2));
			subtotalTable.AddCell(getCell(bestelling.FormattedPrijs(),2));

			doc.Add(subtotalTable);

			Paragraph disclamer = new Paragraph("Betaling : 30 dagen netto\nGoederen geleverd binnen 't kader van art. 27 2e lid van de wet op de omzetbelasting van 1968.");

			doc.Add(disclamer);

			doc.Close();

			Process proc = new Process();
			proc.StartInfo.FileName = filepath;
			proc.StartInfo.UseShellExecute = true;
			proc.Start();
		}

		private PdfPCell getCell(string text, int alignment)
		{
			PdfPCell cell = new PdfPCell(new Phrase(text));
			cell.Padding = 0;
			cell.HorizontalAlignment = alignment;
			cell.Border = PdfPCell.NO_BORDER;
			return cell;
		}

		private PdfPHeaderCell HeaderCell(string CellContent)
		{
			PdfPHeaderCell cell = new PdfPHeaderCell();
			cell.BackgroundColor = CMYKColor.LIGHT_GRAY;
			cell.HorizontalAlignment = 1;
			cell.Phrase = new Phrase(CellContent);
			cell.Padding = 5f;
			return cell;
		}

		private PdfPCell productCell(string text)
		{
			PdfPCell cell = new PdfPCell(new Phrase(text));
			cell.Padding = 0;
			cell.HorizontalAlignment = 1;
			cell.Padding = 5f;
			return cell;
		}

		private PdfPCell BlankCell()
		{
			PdfPCell cell = new PdfPCell(new Phrase(""));
			cell.Border = PdfPCell.NO_BORDER;
			return cell;
		}

		private PdfPCell getImageCell(string filePathImage, int alignment)
		{
			Image img = Image.GetInstance(filePathImage);
			PdfPCell cell = new PdfPCell(img, true);
			cell.HorizontalAlignment = alignment;
			cell.Border = PdfPCell.NO_BORDER;
			return cell;
		}
	}
}
