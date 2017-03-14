using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalSanicElectronics
{
    class Price
    {
        public static double UserPrice(RadioButton consoleBundleOne, RadioButton consoleBundleTwo, RadioButton consoleBundleThree,
            RadioButton consoleWarrantyOne, RadioButton consoleWarrantyTwo, RadioButton consoleWarrantyThree,
            RadioButton computerWarrantyOne, RadioButton computerWarrantyTwo, RadioButton computerWarrantyThree,
            RadioButton tabletWarrantyOne, RadioButton tabletWarrantyTwo, RadioButton tabletWarrantyThree,
            RadioButton televisionWarrantyOne, RadioButton televisionWarrantyTwo, RadioButton televisionWarrantyThree,
            double userPrice)
        {
            //Adding Console Bundle price information to the userPrice variable so it has an accumulated overall price
            if (consoleBundleOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (consoleBundleTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (consoleBundleThree.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Console Warranty price information to the userPrice variable so it has an accumulated overall price
            if (consoleWarrantyOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (consoleWarrantyTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (consoleWarrantyThree.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Computer Warranty price information to the userPrice variable so it has an accumulated overall price
            if (computerWarrantyOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (computerWarrantyTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (computerWarrantyThree.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Tablet Warranty price information to the userPrice variable so it has an accumulated overall price
            if (tabletWarrantyOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (tabletWarrantyTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (tabletWarrantyThree.Checked)
            {
                userPrice += 60.00;
            }

            //Adding Television Warranty price information to the userPrice variable so it has an accumulated overall price
            if (televisionWarrantyOne.Checked)
            {
                userPrice += 30.00;
            }
            else if (televisionWarrantyTwo.Checked)
            {
                userPrice += 45.00;
            }
            else if (televisionWarrantyThree.Checked)
            {
                userPrice += 60.00;
            }

            return userPrice;
        }
    }
}
