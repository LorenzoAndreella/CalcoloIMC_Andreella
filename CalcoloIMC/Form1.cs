namespace CalcoloIMC
{
    public partial class Form1 : Form
    {
        struct Persona
        {
            public string nome;
            public int peso;
            public int altezza;
            public double imc;
            public Persona(string nome, int peso, int altezza, double imc) {
                this.nome = nome;
                this.peso = peso;
                this.altezza = altezza;
                this.imc = imc;
            }

            public string Stampa()
            {
                return $"Nome: {nome}   Peso: {peso}kg    Altezza: {altezza}cm";
            }
        }

        List<Persona> persone = new List<Persona>();            //lista per le persone
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRisposta.Text = "";
            string nome = txtCognNome.Text;
            bool x;
            bool y;
            int peso;
            x = int.TryParse(txtPeso.Text, out peso);        
            int altezza;
            double altezzaMetri;
            y = int.TryParse(txtAltezza.Text, out altezza);
            if (peso < 1 || peso > 500 || altezza < 50 || altezza > 300 || nome == "" || !x || !y) 
            {
                txtRisposta.Text = "Errore, inserisci dati corretti";
                return;
            }
            altezzaMetri = (double)altezza / 100;           //imc calcolato con l'altezza in metri
            double imc = 1;
            imc = peso / Math.Pow(altezzaMetri, 2);
            imc = Math.Round(imc, 2);
            Persona pers = new Persona(nome, peso, altezza, imc);
            persone.Add(pers);
            lstPersone.Items.Add(pers.Stampa());            //listbox
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            if (persone.Count == 0)
            {
                txtRisposta.Text = "Nessuna persona";
                return;
            }
            if (rdbIMC.Checked)
            {
                CalcoloIMC();
            } else if (rdbMedia.Checked)
            {
                CalcoloMedia();
            } else if (rdbModa.Checked) 
            {   
                CalcoloModa();
            } else if (rdbMediana.Checked)
            {
                CalcoloMediana();
            } else if (rdbVarianza.Checked)
            {
                CalcoloVarianza();
            } else if (rdbMediaSottoGruppo.Checked)
            {
                CalcoloGruppo();
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar !=(char)Keys.Back && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;            
            }
        }

        private void txtAltezza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Clear)
            {
                e.KeyChar = (char)0;
            }
        }

        private void CalcoloIMC()
        {
            if (lstPersone.SelectedIndex == -1) 
            {
                txtRisposta.Text = "Seleziona una persona!";
                return;
            }

            
            Persona pers = persone[lstPersone.SelectedIndex];           //persona selezionata
            string cat;
            if (pers.imc < 18.5) cat = "sottopeso";
            else if (pers.imc < 24.9) cat = "normopeso";
            else if (pers.imc < 29.9) cat = "sovrappeso";
            else cat = "obeso";


            txtRisposta.Text = $"IMC : {pers.imc}. Sei nella fascia: {cat}";
            
        }

        private void CalcoloMedia()
        {
            double media = 0;
            foreach (var pers in persone)
            {
                media += pers.imc;
            }
            media /= persone.Count;
            media = Math.Round(media,2);

            txtRisposta.Text = $"La media degli IMC: {media}";
        }

        private void CalcoloModa()
        {
            int sottopeso = 0, normopeso = 0, sovrappeso = 0, obeso = 0;

            foreach (var pers in persone)
            {
                if (pers.imc < 18.5) sottopeso++;
                else if (pers.imc < 24.9) normopeso++;
                else if (pers.imc < 29.9) sovrappeso++;
                else obeso++;
            }
            int max = sottopeso;
            if (normopeso > max) max = normopeso;
            if (sovrappeso > max) max = sovrappeso;
            if (obeso > max) max = obeso;

            string moda = "";                       //mi serve per mettere insieme eventuali mode uguali
            if (sottopeso == max)
            {
                if (moda != "") moda += ", ";           //!=" " --> allora significa che c'è già qualcosa quindi ","
                moda += "sottopeso";
            }
            if (normopeso == max)
            {
                if (moda != "") moda += ", ";
                moda += "normopeso";
            }
            if (sovrappeso == max)
            {
                if (moda != "") moda += ", ";
                moda += "sovrappeso";
            }
            if (obeso == max)
            {
                if (moda != "") moda += ", ";
                moda += "obeso";
            }

            txtRisposta.Text = $"Moda: {moda} con {max} persone";

        }

        private void CalcoloMediana()
        {
            if (persone.Count == 0)
            {
                txtRisposta.Text = "Nessuna persona inserita!";
                return;
            }

            List<double> listaIMC = new List<double>();

            foreach (var pers in persone)
            {
                double altezzaM = pers.altezza / 100.0;
                double imc = pers.peso / (altezzaM * altezzaM);
                listaIMC.Add(imc);
            }

            listaIMC.Sort(); //ordine crescente

            double mediana;
            int n = listaIMC.Count;

            if (n % 2 == 0)
            {
                int i1 = n / 2 - 1;             //valori 
                int i2 = n / 2;                 //centrali
                mediana = (listaIMC[i1] + listaIMC[i2]) / 2.0; 
            }
            else
            {
                mediana = listaIMC[n / 2];
            }

            mediana = Math.Round(mediana, 2);          
            txtRisposta.Text = $"La mediana è {mediana}";
        }

        private void CalcoloVarianza()
        {
            double media = 0;
            foreach (var pers in persone)
            {
                media += pers.imc;
            }
            media = media/persone.Count;

            double ScartiQuadratici = 0;

            foreach (var pers in persone)
            {
                double scarto = pers.imc - media;
                ScartiQuadratici += Math.Pow(scarto, 2);
            }

            double varianza = ScartiQuadratici / persone.Count;
            varianza = Math.Round(varianza,2);

            txtRisposta.Text = $"La varianza vale: {varianza}";
        }

        private void CalcoloGruppo()
        {
            int sottopeso = 0, normopeso = 0, sovrappeso = 0, obeso = 0;

            double sotpe = 0, normope = 0, sovrappe = 0, ob = 0;
            double media1 = 0, media2 = 0, media3 = 0, media4 = 0;

            foreach (var pers in persone)
            {
                if (pers.imc < 18.5)
                {
                    sottopeso++;
                    sotpe += pers.imc;
                }
                else if (pers.imc < 24.9) 
                {
                    normopeso++;
                    normope += pers.imc;
                } 
                else if (pers.imc < 29.9) 
                {
                    sovrappeso++;
                    sovrappe += pers.imc;
                } 
                else 
                {
                    obeso++;
                    ob += pers.imc;
                } 
            }
            if (sottopeso != 0) media1 = Math.Round(sotpe / sottopeso, 2);              //evitare di fare diviso 0
            if (normopeso != 0) media2 = Math.Round(normope / normopeso, 2);
            if (sovrappeso != 0) media3 = Math.Round(sovrappe / sovrappeso, 2);
            if (obeso != 0) media4 = Math.Round(ob / obeso, 2);
            txtRisposta.Text = $"Sottopeso: {media1}   Normopeso: {media2}  Sovrappeso: {media3}    Obeso: {media4}";
        }

    }
}
