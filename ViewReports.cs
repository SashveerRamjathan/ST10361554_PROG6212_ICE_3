using ST10361554_PROG6212_ICE_3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10361554_PROG6212_ICE_3
{
    public partial class ViewReports : Form
    {
        private readonly FinanceTracker _financeTracker;
        private readonly Report _report;

        public ViewReports(FinanceTracker financeTracker, Report report)
        {
            InitializeComponent();
            _financeTracker = financeTracker;
            _report = report;
            YearNumBox.Maximum = DateTime.Now.Year;
            MonthlyYearNumbox.Maximum = DateTime.Now.Year;
            YearNumBox.Value = DateTime.Now.Year;
            MonthlyYearNumbox.Value = DateTime.Now.Year;
            LoadMonths();
        }

        private void GenerateReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if the weekly radio button is checked
                if (WeeklyRadioButton.Checked)
                {
                    #region Generate Weekly Report

                    // check if the period between start date and end date is valid
                    if (StartDateTimePicker.Value > EndDateTimePicker.Value)
                    {
                        MessageBox.Show("Start date cannot be greater than end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // check if the period between start date and end date is the same day
                    if (StartDateTimePicker.Value == EndDateTimePicker.Value)
                    {
                        MessageBox.Show("Start date cannot be the same as end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // get the start date
                    DateOnly startDate = DateOnly.FromDateTime(StartDateTimePicker.Value);

                    // get the end date
                    DateOnly endDate = DateOnly.FromDateTime(EndDateTimePicker.Value);

                    // clear the rich text box
                    ReportRichTextBox.Clear();

                    // get the report details
                    var details = _report.GenerateWeeklyReport(startDate, endDate);

                    // add the report details to the rich text box
                    foreach (var detail in details)
                    {
                        ReportRichTextBox.AppendText(detail);
                        ReportRichTextBox.AppendText(Environment.NewLine);
                    }

                    // display message box
                    MessageBox.Show("Weekly report generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #endregion
                }

                // check if the monthly radio button is checked
                if (MonthlyRadioButton.Checked)
                {
                    #region Generate Monthly Report

                    // check if a month is selected
                    if (MonthsComboBox.SelectedIndex == -1 || MonthsComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // check if a year is entered
                    if (MonthlyYearNumbox.Value == 0)
                    {
                        MessageBox.Show("Please enter a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // get the selected month
                    string month = MonthsComboBox.SelectedItem.ToString()!;

                    // get the selected year
                    string year = MonthlyYearNumbox.Value.ToString();

                    // clear the rich text box
                    ReportRichTextBox.Clear();

                    // get the report details
                    var details = _report.GenerateMonthlyReport(month, year);

                    // add the report details to the rich text box
                    foreach (var detail in details)
                    {
                        ReportRichTextBox.AppendText(detail);
                        ReportRichTextBox.AppendText(Environment.NewLine);
                    }

                    // display message box
                    MessageBox.Show("Monthly report generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #endregion
                }

                // check if the yearly radio button is checked
                if (YearlyRadioButton.Checked)
                {
                    #region Generate Yearly Report

                    // check if a year is entered
                    if (YearNumBox.Value == 0)
                    {
                        MessageBox.Show("Please enter a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // get the selected year
                    string year = YearNumBox.Value.ToString();

                    // clear the rich text box
                    ReportRichTextBox.Clear();

                    // get the report details
                    var details = _report.GenerateYearlyReport(year);

                    // add the report details to the rich text box
                    foreach (var detail in details)
                    {
                        ReportRichTextBox.AppendText(detail);
                        ReportRichTextBox.AppendText(Environment.NewLine);
                    }

                    // display message box
                    MessageBox.Show("Yearly report generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #endregion
                }
            }
            catch (Exception ex)
            {
                // display an error message
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // clear the rich text box
            ReportRichTextBox.Clear();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WeeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // make the weekly panel visible
            WeeklyPanel.Visible = true;

            // make the monthly panel invisible
            MonthlyPanel.Visible = false;

            // make the yearly panel invisible
            YearlyPanel.Visible = false;
        }

        private void MonthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // make the monthly panel visible
            MonthlyPanel.Visible = true;

            // make the weekly panel invisible
            WeeklyPanel.Visible = false;

            // make the yearly panel invisible
            YearlyPanel.Visible = false;
        }

        private void YearlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // make the yearly panel visible
            YearlyPanel.Visible = true;

            // make the weekly panel invisible
            WeeklyPanel.Visible = false;

            // make the monthly panel invisible
            MonthlyPanel.Visible = false;
        }

        private void LoadMonths()
        {
            List<string> months = new List<string>()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            MonthsComboBox.DataSource = months;
        }

        private void CategorySpendingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region Generate category spending report for a specific month

                // check if a month is selected
                if (MonthsComboBox.SelectedIndex == -1 || MonthsComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // check if a year is entered
                if (MonthlyYearNumbox.Value == 0)
                {
                    MessageBox.Show("Please enter a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get the selected month
                string month = MonthsComboBox.SelectedItem.ToString()!;

                // get the selected year
                string year = MonthlyYearNumbox.Value.ToString();

                // clear the rich text box  
                ReportRichTextBox.Clear();

                // get the report details
                string details = _financeTracker.GenerateSpendingReportByCategory(year, month);

                // add the report details to the rich text box
                foreach (var detail in details)
                {
                    ReportRichTextBox.AppendText(details);
                }

                // display message box
                MessageBox.Show("Category spending report generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #endregion
            }
            catch (Exception ex)
            {
                // display an error message
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MonthlySavingsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region Calculate monthly savings

                // check if a month is selected
                if (MonthsComboBox.SelectedIndex == -1 || MonthsComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a month", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // check if a year is entered
                if (MonthlyYearNumbox.Value == 0)
                {
                    MessageBox.Show("Please enter a year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // get the selected month
                string month = MonthsComboBox.SelectedItem.ToString()!;

                // get the selected year
                string year = MonthlyYearNumbox.Value.ToString();

                // clear the rich text box
                ReportRichTextBox.Clear();

                // get the report details
                double savings = _financeTracker.CalculateSavingsForMonth(year, month);

                // add the report details to the rich text box
                ReportRichTextBox.AppendText($"Savings for {month} {year}: {savings}");

                // display message box
                MessageBox.Show("Monthly savings calculated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #endregion
            }
            catch (Exception ex)
            {
                // display an error message
                MessageBox.Show($"Error calculating savings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OverspendingCategoriesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region Identify overspending categories

                // get the report details
                string report = _financeTracker.IdentifyOverspendingCategories();

                // clear the rich text box
                ReportRichTextBox.Clear();

                if (report == null)
                {
                    ReportRichTextBox.AppendText("No overspending categories identified");
                }

                // add the report details to the rich text box
                ReportRichTextBox.AppendText(report);

                // display message box
                MessageBox.Show("Overspending categories identified successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                #endregion
            }
            catch (Exception ex)
            {
                // display an error message
                MessageBox.Show($"Error identifying overspending categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
