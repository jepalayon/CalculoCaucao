using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaucaoCalculo
{
    public partial class Form1 : Form
    {
        decimal valorCaucao = 0, reaisDia = 0, multaSaida = 0, restoCaucao = 0;
        DateTime dataFinal, dataInicial, dataSaida, dataFinalCbMulta;
        TimeSpan totalDias, diasPFinal;
        public Form1()
        {
            InitializeComponent();
        }

        private void TxbValorCauçao_TextChanged(object sender, EventArgs e)
        {
            // validação de entrada só de números
            if (txbValorCaucao != null)
            {
                try
                {
                    valorCaucao = Convert.ToDecimal(txbValorCaucao.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("ERRO! Campo só aceita números");
                    txbValorCaucao.SelectAll();
                    txbValorCaucao.Focus();
                    return;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e) => Close();

        private void TxbDtFinalCaucao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (valorCaucao == 0)
            {
                try
                {
                    valorCaucao = Convert.ToDecimal(txbValorCaucao.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Valor da Caução deve ser maior que zero");
                    txbValorCaucao.SelectAll();
                    txbValorCaucao.Focus();
                    return;
                }
            }

            dataFinal = DateTime.Parse(dtDataFinalContrato.Text);
            dataInicial = DateTime.Parse(dtDataInicioCont.Text);
            totalDias = dataFinal - dataInicial;
            txbTotalDias.Text = totalDias.Days.ToString();

            dataSaida = DateTime.Parse(dtDataSaida.Text);
            dataFinalCbMulta = DateTime.Parse(dtFinalMulta.Text);

            if (dataSaida > dataFinalCbMulta)
            {
                MessageBox.Show("Não há multa a ser paga pelo locatário");
                txbRestoCaucao.Text = txbValorCaucao.Text;
            }
            else
            {
                reaisDia = valorCaucao / totalDias.Days;
                txbReaisDia.Text = reaisDia.ToString("N2");

                diasPFinal = dataFinal - dataSaida;
                txbDiasPrFinal.Text = diasPFinal.Days.ToString();

                multaSaida = diasPFinal.Days * reaisDia;
                txbMultaSaida.Text = multaSaida.ToString("N2");

                restoCaucao = valorCaucao - multaSaida;
                txbRestoCaucao.Text = restoCaucao.ToString("N2");
            }
        }

        private void DtDataFinalContrato_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
