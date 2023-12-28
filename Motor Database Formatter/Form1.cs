namespace Motor_Database_Formatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox_TextChanged(this, EventArgs.Empty);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            txtHTML.Text =
                "            <tr>\n               <td><img src=\"" +
                txtImage.Text +
                "\" alt=\"Image\" width=\"128\" height=\"128\"></td>\n               <td>" +

                txtManufacturer.Text +
                "</td>\n               <td>" +

                txtName.Text +
                "</td>\n               <td>" +

                txtPrice.Text +
                "</td>\n               <td>" +

                txtStatorDiameter.Text +
                "</td>\n               <td>" +

                txtStatorDiameter.Text +
                "</td>\n               <td>" +

                txtStatorHeight.Text +
                "</td>\n               <td>" +

                txtStatorConfiguration.Text +
                "</td>\n               <td>" +

                txtFluxDirection.Text +
                "</td>\n               <td>" +

                txtKV.Text +
                "</td>\n               <td>" +

                txtInternalResistance.Text +
                "</td>\n               <td>" +

                txtEnamelType.Text +
                "</td>\n               <td>" +

                txtEfficiency.Text +
                "</td>\n               <td>" +

                txtRatedTorque.Text +
                "</td>\n               <td>" +

                txtWeightInclCable.Text +
                "</td>\n               <td>" +

                txtWeightExclCable.Text +
                "</td>\n               <td>" +

                txtCableLength.Text +
                "</td>\n               <td>" +

                txtCableGauge.Text +
                "</td>\n               <td>" +

                txtConnector.Text +
                "</td>\n               <td>" +

                txtShaftDiameterExternal.Text +
                "</td>\n               <td>" +

                txtShaftDiameterInternal.Text +
                "</td>\n               <td>" +

                txtShaftRetention.Text +
                "</td>\n               <td>" +

                txtBearingType.Text +
                "</td>\n               <td>" +

                txtMagnetType.Text +
                "</td>\n               <td>" +

                txtMountingCircle.Text +
                "</td>\n               <td>" +

                txtNumberOfMountingScrews.Text +
                "</td>\n               <td>" +

                txtMountingScrewThread.Text +
                "</td>\n               <td>" +

                txtMaximumOperatingTemperature.Text +
                "</td>\n               <td>" +

                txtCoolingMethod.Text +
                "</td>\n               <td>" +

                txtIPRating.Text +
                "</td>\n               <td><a href=\"" +

                txtLink.Text +
                "\">" +
                txtLink.Text +
                "</a></td>\n            </tr>"
            ;
        }
    }
}