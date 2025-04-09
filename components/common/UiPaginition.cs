using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace IdCard.Hanel_obj.components
{
    public partial class UiPaginition : UserControl
    {
        public delegate void PageChangedEventHandler(int newPage);
        public event PageChangedEventHandler OnPageChanged = delegate { };

        private int _totalPages;
        private int _currentPage;

        public int TotalPages
        {
            get => _totalPages;
            set
            {
                _totalPages = value;
                UpdatePaginationDisplay();
            }
        }

        public int CurrentPage
        {
            get => _currentPage;
            set
            {
                if (value >= 1 && value <= _totalPages)
                {
                    _currentPage = value;
                    UpdatePaginationDisplay();
                    //OnPageChanged?.Invoke(_currentPage);
                }
            }
        }

        public UiPaginition()
        {
            InitializeComponent();
        }

        private void UpdatePaginationDisplay()
        {
            pnlPages.Controls.Clear();

            int buttonSpacing = 10; // Space between buttons
            int buttonWidth = 30;
            int buttonHeight = 30;
            int startX = 0; // Starting X position for the first button

            // Position the "Previous" button
            btnPrevious.Location = new Point(startX, 0);
            btnPrevious.Width = buttonWidth;
            btnPrevious.Height = buttonHeight;


            pnlPages.Controls.Add(btnPrevious);
            startX += buttonWidth + buttonSpacing;

            // Add sibling pages and current page
            for (int i = Math.Max(1, _currentPage - 2); i <= Math.Min(_totalPages, _currentPage + 2); i++)
            {
                var btnPage = new Button
                {
                    Text = i.ToString(),
                    Tag = i,
                    Enabled = i != _currentPage,
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new Point(startX, 0) // Set button position
                };
                startX += buttonWidth + buttonSpacing; // Update X position for the next button

                btnPage.Click += (s, e) =>
                {
                    if (s is Button button && button.Tag is int page)
                    {
                        CurrentPage = page;
                        this.OnPageChanged?.Invoke(page);
                    }
                };
                pnlPages.Controls.Add(btnPage);
            }

            // Position the "Next" button
            btnNext.Location = new Point(startX, 0);
            btnNext.Width = buttonWidth;
            btnNext.Height = buttonHeight;

            pnlPages.Controls.Add(btnNext);

            // Enable/disable navigation buttons
            btnPrevious.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (_currentPage > 1)
            {
                CurrentPage--;
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_currentPage < _totalPages)
            {
                CurrentPage++;
            }
        }

    }

}
