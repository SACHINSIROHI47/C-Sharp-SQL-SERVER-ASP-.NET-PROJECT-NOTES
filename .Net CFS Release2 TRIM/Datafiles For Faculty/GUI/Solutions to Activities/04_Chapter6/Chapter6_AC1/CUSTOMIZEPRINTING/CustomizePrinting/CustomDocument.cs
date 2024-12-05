using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;


namespace CustomizePrinting
{
    class CustomDocument : PrintDocument
    {
        private Font _printFont;
		private string _fileToPrint;
		private Single _headerHeight;
		private TextReader _printStream;
		// Private bitmap field

		
		// String property to set and retrive the file to print.
		public string FileToPrint
		{
			get
			{ 
				return _fileToPrint;
			}
			set
			{
				if (File.Exists(value))
				{
					_fileToPrint = value;
				}
				else
					throw(new Exception("File not found."));
			}
		}
		// Font property to get and set the font to be used.
		public Font PrintFont
		{
			get 
			{ 
				return _printFont; 
			}
			set 
			{ 
				_printFont = value; 
			}
		}
		// Get and Set the height of header section.
		public Single HeaderHeight
		{
			get
			{
				return _headerHeight;
			}
			set
			{
				_headerHeight = value;
			}
		}
		protected virtual Single printPageHeader(RectangleF bounds, PrintPageEventArgs e)
		{
			// Create drawing surface.
			Graphics g = e.Graphics;
			// Specify font for header.
			Font drawFont = new Font("Arial", 16,FontStyle.Bold);
			// To Get the text to be displayed in the header.
			string headerText = this.DocumentName;
			// To Get the bounds of the header.
			RectangleF headerTextLayout = new RectangleF(bounds.X, bounds.Y, bounds.Width, bounds.Height);

			Single localHeaderHeight;

			// Header should be center aligned.
			StringFormat headerStringFormat = new StringFormat();
			headerStringFormat.Alignment = StringAlignment.Center;

			// Calculate the height of the header.
			localHeaderHeight = g.MeasureString(headerText, drawFont, headerTextLayout.Size, headerStringFormat).Height;

			// Draw the header.
			g.DrawString(headerText, drawFont,Brushes.Black, headerTextLayout, headerStringFormat);

			// Return the header height.
			return localHeaderHeight;
		}

		protected override void OnBeginPrint(PrintEventArgs e) 
		{
			base.OnBeginPrint(e);
			// Initialize the text reader.
			_printStream = new StreamReader(FileToPrint);
		}

		protected override void OnEndPrint(PrintEventArgs e)
		{
			base.OnEndPrint(e);
			// Close the text reader.
			_printStream.Close();
		}

		protected override void OnPrintPage(PrintPageEventArgs e) 
		{
			base.OnPrintPage(e);

			// Create the drawing surface.
			Graphics gdiPage = e.Graphics;

			// Get the bounds of the print area.
			Single leftMargin = e.MarginBounds.Left;
			Single topMargin = e.MarginBounds.Top;
			Single width = e.MarginBounds.Width;
			Single height = e.MarginBounds.Height;

			// Calculate line height and lines per page;
			Single lineHeight = _printFont.GetHeight(gdiPage);
			Single linesPerPage = e.MarginBounds.Height / lineHeight;

			int lineCount = 0;
			string lineText = null;
			Single headerSize;
			Single currentPosition = topMargin;

			// Specify the header area.
			RectangleF headerBounds = new RectangleF(leftMargin, topMargin, width, height);
			// Get the value of the height property.
			headerBounds.Height = this.HeaderHeight;
			// Print the page header and retrieve the height of the header.
			headerSize = printPageHeader(headerBounds, e);

			// Specify the current position to ensure that line printing
			// begins below the header.
			currentPosition += (headerSize + 20);

	

			// Draw each line of text in turn.
			while (lineCount < linesPerPage && 
                  ((lineText = _printStream.ReadLine()) != null)) 
			{
				gdiPage.DrawString(lineText, _printFont, Brushes.Black, 
                        leftMargin, (currentPosition + (lineCount++ * lineHeight)));
			}

			// Check if the end of the file has been reached and set HasMorePages property.
			if(lineText != null)
				e.HasMorePages = true;
			else
				e.HasMorePages = false;
		}

    }
}
