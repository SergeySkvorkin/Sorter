namespace WinFormsApp1
{
    public partial class SORTER : Form
    {
// Переменные 
       
        
        public bool cardboarDirt = false;
        public bool cardboarDamage = false;
        public bool cardboarWritings = false;
        public bool cardboarStickers = false;
        public bool cardboarDent = false;
        public string cardboardOther;

        public bool laptopDirt = false;
        public bool laptopDamage = false;
        public bool laptopWritings = false;
        public bool laptopStickers = false;
        public bool laptopScretchs = false;
        public string laptopOther;

        public bool equipmentLodgment = false;
        public bool equipmentBag = false;
        public bool equipmentPapers = false;
        public bool equipmentCharger = false;



        

        public SORTER()
        {
            InitializeComponent();
        }



//Секция коробки
        private void chBoxCardboardDamage_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                cardboarDamage = true;
            }
            else
            {
                cardboarDamage = false;
            }
        }
        private void chBoxCardboardDirt_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                cardboarDirt = true;
            }
            else
            {
                cardboarDirt = false;
            }
        }
        private void chBoxCardboardWritings_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                cardboarWritings = true;
            }
            else
            {
                cardboarWritings = false;
            }
        }
        private void chBoxCardboardStickers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                cardboarStickers = true;
            }
            else
            {
                cardboarStickers = false;
            }
        }
        private void chBoxCardboardDent_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                cardboarDent = true;
            }
            else
            {
                cardboarDent = false;
            }
        }

        private string cardboardStringBuilder()
        {
            string cardboard = "";
            cardboardOther = txtBoxCardboardOther.Text;
            if (!cardboarDamage && !cardboarDirt && !cardboarDent && !cardboarStickers && !cardboarWritings && String.IsNullOrEmpty(cardboardOther))
            {
                cardboard = "Целая";
            }
            else
            {
                if (cardboarDirt) { cardboard += "Грязь "; }
                if (cardboarDamage) { cardboard += "Повреждения "; }
                if (cardboarDent) { cardboard += " Вмятины "; }
                if (cardboarStickers) { cardboard += " Наклейки/скотч "; }
                if (cardboarWritings) { cardboard += " Надписи"; }
                if (!String.IsNullOrEmpty(cardboardOther)) { cardboard +=" " +  cardboardOther; }
            }
            return cardboard;

        }

//Секция корпуса
        private void chBoxLaptopScretchs_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                laptopScretchs = true;
            }
            else
            {
                cardboarDamage = false;
            }
        }
        private void chBoxLaptopDirt_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                laptopDirt = true;
            }
            else
            {
                laptopDirt = false;
            }
        }
        private void chBoxLaptopWritings_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                laptopWritings = true;
            }
            else
            {
                laptopWritings = false;
            }
        }
        private void chBoxLaptopStickers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                laptopStickers = true;
            }
            else
            {
                laptopStickers = false;
            }
        }
        private void chBoxLaptopDamage_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                laptopDamage = true;
            }
            else
            {
                laptopDamage = false;
            }
        }

        private string laptopStringBuilder()
        {
            string laptop = "";
            laptopOther = txtBoxLaptopOther.Text;
            if (!laptopScretchs && !laptopDirt && !laptopDamage && !laptopStickers && !laptopWritings && String.IsNullOrEmpty(laptopOther))
            {
                laptop = "Целая";
            }
            else
            {
                if (laptopDirt) { laptop += "Грязь "; }
                if (laptopScretchs) { laptop += "Царапины "; }
                if (laptopDamage) { laptop += "Повреждения "; }
                if (cardboarStickers) { laptop += " Наклейки/скотч "; }
                if (cardboarWritings) { laptop += " Надписи"; }
                if (!String.IsNullOrEmpty(laptopOther)) { laptop += " " + laptopOther; }
            }
            return laptop;

        }

//Секция комплектации

        private void chBoxEquipmentLodgment_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                equipmentLodgment = true;
            }
            else
            {
                equipmentLodgment = false;
            }
        }
        private void chBoxEquipmentBag_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                equipmentBag = true;
            }
            else
            {
                equipmentBag = false;
            }
        }
        private void chBoxEquipmentPapers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                equipmentPapers = true;
            }
            else
            {
                equipmentPapers = false;
            }
        }

        private void chBoxEquipmentPapers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                equipmentPapers = true;
            }
            else
            {
                equipmentPapers = false;
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            
            string laptopSN = txtBoxLaptopSn.Text;
            string cardboardSN = txtBoxCardboardSn.Text;
            string cardboardString = cardboardStringBuilder();
            string laptopString = laptopStringBuilder();
            MessageBox.Show("Серийник коробки: " + cardboardSN + "\n" +
                            "Серийник ноутбука: " + laptopSN + "\n" +
                            "Проблемы коробки: " + cardboardString + "\n" +
                            "проблемы ноутбука: " + laptopString);

        }





    }
}