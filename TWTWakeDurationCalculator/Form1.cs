using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace WiFi6TWTCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            clearForDataEntry();
            clearResults();
        }

        private void tbDays_TextChanged(object sender, EventArgs e)
        {

            if (tbDays.Text == "")
                tbDays.Text = "0";

            //allow only numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(tbDays.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbDays.Text = tbDays.Text.Remove(tbDays.Text.Length - 1);
            }

            calculateTotalMicroseconds();

            clearResults();

        }

        private void tbHours_TextChanged(object sender, EventArgs e)
        {

            if (tbHours.Text == "")
                tbHours.Text = "0";

            //allow only numbers between 0 and 23
            if (System.Text.RegularExpressions.Regex.IsMatch(tbHours.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbHours.Text = tbHours.Text.Remove(tbHours.Text.Length - 1);
            }
            if (Convert.ToInt32(tbHours.Text) > 23)
            {
                MessageBox.Show("Please enter a number between 0 and 23.");
                tbHours.Text = tbHours.Text.Remove(tbHours.Text.Length - 1);
            }

            calculateTotalMicroseconds();

            clearResults();

        }

        private void tbMinutes_TextChanged(object sender, EventArgs e)
        {

            if (tbMinutes.Text == "0")
                tbMinutes.Text = "0";

            //allow only numbers between 0 and 59
            if (System.Text.RegularExpressions.Regex.IsMatch(tbMinutes.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbMinutes.Text = tbMinutes.Text.Remove(tbMinutes.Text.Length - 1);
            }

            if (Convert.ToInt32(tbMinutes.Text) > 59)
            {
                MessageBox.Show("Please enter a number between 0 and 59.");
                tbMinutes.Text = tbMinutes.Text.Remove(tbMinutes.Text.Length - 1);
            }

            calculateTotalMicroseconds();

            clearResults();

        }

        private void tbSeconds_TextChanged(object sender, EventArgs e)
        {

            if (tbSeconds.Text == "")
                tbSeconds.Text = "0";

            //allow only numbers between 0 and 59
            if (System.Text.RegularExpressions.Regex.IsMatch(tbSeconds.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbSeconds.Text = tbSeconds.Text.Remove(tbSeconds.Text.Length - 1);
            }
            if (Convert.ToInt32(tbSeconds.Text) > 59)
            {
                MessageBox.Show("Please enter a number between 0 and 59.");
                tbSeconds.Text = tbSeconds.Text.Remove(tbSeconds.Text.Length - 1);
            }

            calculateTotalMicroseconds();

            clearResults();

        }

        private void tbMicroseconds_TextChanged(object sender, EventArgs e)
        {

            if (tbMicroseconds.Text == "")
                tbMicroseconds.Text = "0";

            //allow only numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(tbMicroseconds.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbMicroseconds.Text = tbMicroseconds.Text.Remove(tbMicroseconds.Text.Length - 1);
            }

            calculateTotalMicroseconds();

            clearResults();

        }

        private void tbMilliseconds_TextChanged(object sender, EventArgs e)
        {

            if (tbMilliseconds.Text == "")
                tbMilliseconds.Text = "0";

            //allow only numbers
            if (System.Text.RegularExpressions.Regex.IsMatch(tbMilliseconds.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbMicroseconds.Text = tbMicroseconds.Text.Remove(tbMilliseconds.Text.Length - 1);
            }

            calculateTotalMicroseconds();

            clearResults();

        }

        private void calculateTotalMicroseconds()
        {

            UInt64 days = 0;
            UInt64 hours = 0;
            UInt64 minutes = 0;
            UInt64 seconds = 0;
            UInt64 microseconds = 0;
            UInt64 milliseconds = 0;
            UInt64 totalMicroseconds = 0;
            //check for empty textboxes
            if (tbDays.Text == "")
            {
                tbDays.Text = "0";
            }
            if (tbHours.Text == "")
            {
                tbHours.Text = "0";
            }
            if (tbMinutes.Text == "")
            {
                tbMinutes.Text = "0";
            }
            if (tbSeconds.Text == "")
            {
                tbSeconds.Text = "0";
            }
            if (tbMilliseconds.Text == "")
            {
                tbMilliseconds.Text = "0";
            }
            if (tbMicroseconds.Text == "")
            {
                tbMicroseconds.Text = "0";
            }
            //calculate total milliseconds
            days = (UInt64)Convert.ToInt64(tbDays.Text);
            hours = (UInt64)Convert.ToInt64(tbHours.Text);
            minutes = (UInt64)Convert.ToInt64(tbMinutes.Text);
            seconds = (UInt64)Convert.ToInt64(tbSeconds.Text);
            milliseconds = (UInt64)Convert.ToInt64(tbMilliseconds.Text);
            microseconds = (UInt64)Convert.ToInt64(tbMicroseconds.Text);

            totalMicroseconds = microseconds + (milliseconds * 1000) + (seconds * 1000000) + (minutes * 60 * 1000000) + (hours * 60 * 60 * 1000000) + (days * 24 * 60 * 60 * 1000000);

            //display total milliseconds
            tbTotalMicroseconds.Text = totalMicroseconds.ToString();

        }


        private void clearForDataEntry()
        {
            tbDays.Text = "0";
            tbHours.Text = "0";
            tbMinutes.Text = "0";
            tbSeconds.Text = "0";
            tbMicroseconds.Text = "0";
            tbMilliseconds.Text = "0";
            tbTotalMicroseconds.Text = "0";

            // gbResults.Visible = false;
        }
        private void clearResults()
        {

            gbResults.Visible = false;
            tbWakeIntervalExponentExact.Text = "";
            tbWakeIntervalExponentOver.Text = "";
            tbWakeIntervalExponentUnder.Text = "";
            tbMantissaExact.Text = "";
            tbMantissaOver.Text = "";
            tbMantissaUnder.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForDataEntry();
            clearResults();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gbResults.Visible = false;

            Application.DoEvents();

            //clear results
            clearResults();

            if (tbTotalMicroseconds.Text == "0")
            {
                System.Media.SystemSounds.Beep.Play();
                return;
            };


            const UInt64 maxMantissa = 65535;
            const UInt64 maxExponent = 31;

            UInt64 closestButOver = UInt64.MaxValue;
            UInt64 closestButUnder = 0;
            UInt64 result = 0;
            UInt64 minResultForThisExponent = 0;
            UInt64 maxResultForThisExponent = 0;

            UInt64 target = (UInt64)Convert.ToInt64(tbTotalMicroseconds.Text);


            //Calculate the mantissa and exponent

            for (UInt64 wakeIntervalExponent = 0; wakeIntervalExponent <= maxExponent; wakeIntervalExponent++)
            {

                // check if this exponent is used it will be greater than the target
                // if so, there is no point in continuing with this exponent
                // However, in the unlikely case the result of using this exponent with a mantinassa of value 1 
                // is less than the current closestButOver, then we need to update closestButOver
                minResultForThisExponent = (UInt64)Math.Pow(2, wakeIntervalExponent);

                if (minResultForThisExponent > target)
                {
                    if (minResultForThisExponent < closestButOver)
                    {
                        closestButOver = minResultForThisExponent;
                        tbMantissaOver.Text = "1";
                        tbWakeIntervalExponentOver.Text = wakeIntervalExponent.ToString();
                    }

                }
                else
                {

                    // check if this exponent is used with the highest possible mantissa will it be less than the target
                    // if so, there is no point in continuing with this exponent
                    // However, in the unlikely case the result of using this exponent with a mantinassa of value 65536
                    // is greater than the current closestButUnder, then we need to update closestButUnder
                    maxResultForThisExponent = maxMantissa * (UInt64)Math.Pow(2, wakeIntervalExponent);

                    if (maxResultForThisExponent < target)
                    {
                        closestButUnder = maxResultForThisExponent;
                        tbMantissaUnder.Text = maxMantissa.ToString();
                        tbWakeIntervalExponentUnder.Text = wakeIntervalExponent.ToString();
                    }
                    else
                    {
                        // we need to check all the possible mantissa values for this exponent
                        for (UInt64 wakeMantissa = 1; wakeMantissa <= maxMantissa; wakeMantissa++)
                        {

                            result = wakeMantissa * (UInt64)Math.Pow(2, wakeIntervalExponent);

                            // if the result is less than the target, then we need to check if it is closer to the target than the current closestButUnder
                            // and if so, update closestButUnder
                            if (result < target)
                            {
                                if (result > closestButUnder)
                                {
                                    closestButUnder = result;
                                    tbMantissaUnder.Text = wakeMantissa.ToString();
                                    tbWakeIntervalExponentUnder.Text = wakeIntervalExponent.ToString();
                                }
                            }
                            // if the result is greater than the target, then we need to check if it is closer to the target than the current closestButOver
                            // and if so, update closestButOver
                            else if (result > target)
                            {
                                if (result < closestButOver)
                                {
                                    closestButOver = result;
                                    tbMantissaOver.Text = wakeMantissa.ToString();
                                    tbWakeIntervalExponentOver.Text = wakeIntervalExponent.ToString();
                                }

                            }
                            else
                            // result == target
                            // we have an exact match, so we can stop looking
                            {
                                tbMantissaExact.Text = wakeMantissa.ToString();
                                tbWakeIntervalExponentExact.Text = wakeIntervalExponent.ToString();
                                break;

                            }

                        }

                        if (result == target)
                        {
                            break;
                        }

                    }
                }
            }

            if (result == target)
            {
                gbExact.Visible = true;
                gbOver.Visible = false;
                gbUnder.Visible = false;
            }
            else
            {
                gbExact.Visible = false;
                gbOver.Visible = true;
                gbUnder.Visible = true;

                gbUnder.Text = "Result under the desired duration by $ microseconds";
                gbUnder.Text = gbUnder.Text.Replace("$", (target - closestButUnder).ToString());
                gbOver.Text = "Result over the desired duration by $ microseconds";
                gbOver.Text = gbOver.Text.Replace("$", (closestButOver - target).ToString());

            }

            //make mouse cursor normal
            gbResults.Visible = true;
            Cursor.Current = Cursors.Default;

            this.Refresh();

            Application.DoEvents();

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();

        }

    }


}