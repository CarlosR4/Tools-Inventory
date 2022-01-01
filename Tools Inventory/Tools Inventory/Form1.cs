using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tools_Inventory
{
    public partial class Form1 : Form
    {
        public List<ElectricTool> ElectricTools = new List<ElectricTool>();
        public List<PneumaticTool> PneumaticTools = new List<PneumaticTool>();
        public List<HandTool> HandTools = new List<HandTool>();
        public Form1()
        {
            InitializeComponent();
        }

        StreamReader inputFile;

        private void ReadFile()
        {
            try
            {
                string line;

                //Hold the tools
                ElectricTool thisElectricTool = new ElectricTool();
                PneumaticTool thisPneumaticTool = new PneumaticTool();
                HandTool thisHandTool = new HandTool();

                //Create a delimiter
                char[] delim = { ',' };

                //open input file
                inputFile = File.OpenText("Inventory.txt");

                //read line
                while(!inputFile.EndOfStream)
                {
                    //Read line form file
                    line = inputFile.ReadLine();

                    //tokenize
                    string[] tokens = line.Split(delim);

                    if(tokens[0]=="Hand Tool")
                    {
                        //assign the tool all of its properties
                        thisHandTool = new HandTool();
                        thisHandTool.Type = tokens[0];
                        thisHandTool.Name = tokens[1];
                        thisHandTool.Number = int.Parse(tokens[2]);
                        thisHandTool.Make = tokens[3];
                        thisHandTool.Width = double.Parse(tokens[4]);
                        thisHandTool.Height = double.Parse(tokens[5]);
                        thisHandTool.Weight = double.Parse(tokens[6]);

                        //add the tool to its list
                        HandTools.Add(thisHandTool);

                        //add the tool to the inventorylistbox
                        inventoryListBox.Items.Add(thisHandTool.Name);

                    }
                    else if (tokens[0]== "Electric Tool")
                    {
                        //assign the electrictool all of its properties
                        thisElectricTool = new ElectricTool();
                        thisElectricTool.Type = tokens[0];
                        thisElectricTool.Name = tokens[1];
                        thisElectricTool.Number = int.Parse(tokens[2]);
                        thisElectricTool.Make = tokens[3];
                        thisElectricTool.Width = double.Parse(tokens[4]);
                        thisElectricTool.Height = double.Parse(tokens[5]);
                        thisElectricTool.Weight = double.Parse(tokens[6]);
                        thisElectricTool.Watts = double.Parse(tokens[7]);
                        thisElectricTool.Volts = double.Parse(tokens[8]);
                        thisElectricTool.Amps = thisElectricTool.Watts / thisElectricTool.Volts;

                        //add the electrictool to its list
                        ElectricTools.Add(thisElectricTool);

                        //add the pneumatictool to the inventorylistbox
                        inventoryListBox.Items.Add(thisElectricTool.Name);
                    }
                    else if (tokens[0]== "Pneumatic Tool")
                    {
                        //assign the pneumatictool all of its properties
                        thisPneumaticTool = new PneumaticTool();
                        thisPneumaticTool.Type = tokens[0];
                        thisPneumaticTool.Name = tokens[1];
                        thisPneumaticTool.Number = int.Parse(tokens[2]);
                        thisPneumaticTool.Make = tokens[3];
                        thisPneumaticTool.Width = double.Parse(tokens[4]);
                        thisPneumaticTool.Height = double.Parse(tokens[5]);
                        thisPneumaticTool.Weight = double.Parse(tokens[6]);
                        thisPneumaticTool.Pressure = double.Parse(tokens[7]);
                        thisPneumaticTool.Muffler_Present = bool.Parse(tokens[8]);

                        //add the pneumatictool to its list
                        PneumaticTools.Add(thisPneumaticTool);

                        //add the pneumatictool to the inventorylistbox
                        inventoryListBox.Items.Add(thisPneumaticTool.Name);
                    }

                }
                //close the file
                inputFile.Close();
            }

            catch(Exception ex)
            {
                //close the file
                inputFile.Close();

                //display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveFile()
        {
            //erase all file info
            System.IO.File.WriteAllText("Inventory.txt", string.Empty);

            //Declare a StreamWriter variable
            StreamWriter outputFile;

            //create a file and get a StreamWritter object
            outputFile = File.AppendText("Inventory.txt");

            for(int i=0; i< HandTools.Count; i++)
            {
                outputFile.WriteLine(HandTools[i].Type + "," + HandTools[i].Name + "," + HandTools[i].Number + "," + HandTools[i].Make + "," + HandTools[i].Width + "," + HandTools[i].Height
                    + "," + HandTools[i].Weight);
            }
            for (int i = 0; i < ElectricTools.Count; i++)
            {
                outputFile.WriteLine(ElectricTools[i].Type + "," + ElectricTools[i].Name + "," + ElectricTools[i].Number + "," + ElectricTools[i].Make + "," + ElectricTools[i].Width + "," + ElectricTools[i].Height
                    + "," + ElectricTools[i].Weight+","+ElectricTools[i].Watts+","+ElectricTools[i].Volts+","+ElectricTools[i].Amps);
            }
            for (int i = 0; i < PneumaticTools.Count; i++)
            {
                outputFile.WriteLine(PneumaticTools[i].Type + "," + PneumaticTools[i].Name + ","+PneumaticTools[i].Number+ "," + PneumaticTools[i].Make + "," + PneumaticTools[i].Width + "," + PneumaticTools[i].Height
                    + "," + PneumaticTools[i].Weight + "," + PneumaticTools[i].Pressure + "," + PneumaticTools[i].Muffler_Present);
            }
            outputFile.Close();
        }
        private bool CheckIfFormOK()
        {
            bool formOK = true;

            formOK = formOK && CheckIfFieldOK(typeTextBox.Text, "string");
            formOK = formOK && CheckIfFieldOK(numberTextBox.Text, "int");
            formOK = formOK && CheckIfFieldOK(nameTextBox.Text, "string");
            formOK = formOK && CheckIfFieldOK(makeTextBox.Text, "string");
            formOK = formOK && CheckIfFieldOK(widthTextBox.Text, "double");
            formOK = formOK && CheckIfFieldOK(heightTextBox.Text, "double");
            formOK = formOK && CheckIfFieldOK(weightTextBox.Text, "double");

            return formOK;
        }
        private bool CheckIfFieldOK(string field, string fieldType)
        {
            int intVariable;
            double doubleVariable;
            

            //Checks if the string is not null or empty
            if (String.IsNullOrEmpty(field))
            {
                MessageBox.Show("At least one required field is empty");
                return false;
            }

            //Checks if the string (the user input) corresponds to the expected data type
            switch (fieldType)
            {
                case "int":  //Checks if the data type is 'int'
                    if (int.TryParse(field, out intVariable) == false)
                    {
                        MessageBox.Show("The value: " + field + " must be a(n) " + fieldType + " value");
                        return false;
                    }
                    break;
                case "double":  //Checks if the data type is 'double'
                    if (double.TryParse(field, out doubleVariable) == false)
                    {
                        MessageBox.Show("The value: " + field + " must be a(n) " + fieldType + " value");
                        return false;
                    }
                    break;
                case "string":
                    //Nothing to do
                    break;
            }

            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();
            ViewMode();
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (numberTextBox.ReadOnly||editRadioButton.Checked)
                {
                    foreach (HandTool entry in HandTools)
                    {
                        if (inventoryListBox.SelectedItem.ToString() == entry.Name)
                        {
                            electricHide();
                            pneumaticHide();

                            typeTextBox.Text = entry.Type;
                            numberTextBox.Text = entry.Number.ToString();
                            nameTextBox.Text = entry.Name;
                            makeTextBox.Text = entry.Make;
                            widthTextBox.Text = entry.Width.ToString();
                            heightTextBox.Text = entry.Height.ToString();
                            weightTextBox.Text = entry.Weight.ToString();

                        }
                    }
                    foreach (ElectricTool entry in ElectricTools)
                    {
                        if (inventoryListBox.SelectedItem.ToString() == entry.Name)
                        {
                            electricShow();
                            pneumaticHide();

                            if(editRadioButton.Checked)
                            {
                                wattsTextBox.ReadOnly = false;
                                voltsTextBox.ReadOnly = false;
                            }
                            this.typeTextBox.Text = entry.Type;
                            numberTextBox.Text = entry.Number.ToString();
                            nameTextBox.Text = entry.Name;
                            makeTextBox.Text = entry.Make;
                            widthTextBox.Text = entry.Width.ToString();
                            heightTextBox.Text = entry.Height.ToString();
                            weightTextBox.Text = entry.Weight.ToString();
                            wattsTextBox.Text = entry.Watts.ToString();
                            voltsTextBox.Text = entry.Volts.ToString();
                            ampsTextBox.Text = entry.Amps.ToString("F");
                        }
                    }
                    foreach (PneumaticTool entry in PneumaticTools)
                    {
                        if (inventoryListBox.SelectedItem.ToString() == entry.Name)
                        {

                            electricHide();
                            pneumaticShow();
                            if(editRadioButton.Checked)
                            {
                                mufflerTextBox.ReadOnly = false;
                                pressureTextBox.ReadOnly = false;
                            }
                            this.typeTextBox.Text = entry.Type;
                            numberTextBox.Text = entry.Number.ToString();
                            nameTextBox.Text = entry.Name;
                            makeTextBox.Text = entry.Make;
                            widthTextBox.Text = entry.Width.ToString();
                            heightTextBox.Text = entry.Height.ToString();
                            weightTextBox.Text = entry.Weight.ToString();
                            pressureTextBox.Text = entry.Pressure.ToString();
                            mufflerTextBox.Text = entry.Muffler_Present.ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter View Mode.");
                }
            }
            catch { }
        }

        private void ViewMode()
        {

            clear();

            typeTextBox.ReadOnly = true;
            numberTextBox.ReadOnly = true;
            nameTextBox.ReadOnly = true;
            makeTextBox.ReadOnly = true;
            widthTextBox.ReadOnly = true;
            heightTextBox.ReadOnly = true;
            weightTextBox.ReadOnly = true;
            wattsTextBox.ReadOnly = true;
            voltsTextBox.ReadOnly = true;
            mufflerTextBox.ReadOnly = true;
            pressureTextBox.ReadOnly = true;

        }

        private void electricShow()
        {
            wattsLabel.Visible = true;
            voltsLabel.Visible = true;
            ampsLabel.Visible = true;
            wattsTextBox.Visible = true;
            voltsTextBox.Visible = true;
            ampsLabel.Visible = true;
            ampsTextBox.Visible = true;
        }
        private void electricHide()
        {
            wattsLabel.Visible = false;
            voltsLabel.Visible = false;
            ampsLabel.Visible = false;
            wattsTextBox.Visible = false;
            voltsTextBox.Visible = false;
            ampsLabel.Visible = false;
            ampsTextBox.Visible = false;
            
        }
        private void pneumaticShow()
        {
            pressureLabel.Visible = true;
            pressureTextBox.Visible = true;
            mufflerPresentLabel.Visible = true;
            mufflerTextBox.Visible = true;
        }
        private void pneumaticHide()
        {
            pressureLabel.Visible = false;
            pressureTextBox.Visible = false;
            mufflerPresentLabel.Visible = false;
            mufflerTextBox.Visible = false;
        }

        private void clear()
        {
            typeTextBox.Text = "";
            numberTextBox.Text = "";
            nameTextBox.Text = "";
            makeTextBox.Text = "";
            widthTextBox.Text = "";
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            voltsTextBox.Text = "";
            wattsTextBox.Text = "";
            ampsTextBox.Text = "";
            mufflerTextBox.Text = "";
            pressureTextBox.Text = "";
        }

        private void viewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(addRadioButton.Checked)
            {
                
                
                numberTextBox.ReadOnly = false;
                nameTextBox.ReadOnly = false;
                makeTextBox.ReadOnly = false;
                widthTextBox.ReadOnly = false;
                heightTextBox.ReadOnly = false;
                weightTextBox.ReadOnly = false;

                clear();

                handButton.Visible = true;
                electricButton.Visible = true;
                pneumaticButton.Visible = true;
                addButton.Visible = true;
                editButton.Visible = false;
            }
            else if(viewRadioButton.Checked)
            {
                clear();
                ViewMode();
                electricHide();
                pneumaticHide();
                handButton.Visible = false;
                electricButton.Visible = false;
                pneumaticButton.Visible = false;
                wattsTextBox.ReadOnly = true;
                voltsTextBox.ReadOnly = true;
                pressureTextBox.ReadOnly = true;
                mufflerTextBox.ReadOnly = true;
                addButton.Visible = false;
                editButton.Visible = false;
            }
            else if(editRadioButton.Checked)
            {
                numberTextBox.ReadOnly = false;
                nameTextBox.ReadOnly = false;
                makeTextBox.ReadOnly = false;
                widthTextBox.ReadOnly = false;
                heightTextBox.ReadOnly = false;
                weightTextBox.ReadOnly = false;

                clear();

                handButton.Visible = false;
                electricButton.Visible = false;
                pneumaticButton.Visible = false;
                addButton.Visible = false;
                editButton.Visible = true;
            }
        }

        private void handButton_Click(object sender, EventArgs e)
        {
            typeTextBox.Text = "Hand Tool";
            electricHide();
            pneumaticHide();

        }

        private void pneumaticButton_Click(object sender, EventArgs e)
        {
            typeTextBox.Text = "Pneumatic Tool";
            electricHide();
            pneumaticShow();
            mufflerTextBox.ReadOnly = false;
            pressureTextBox.ReadOnly = false;
        }

        private void electricButton_Click(object sender, EventArgs e)
        {
            typeTextBox.Text = "Electric Tool";
            pneumaticHide();
            electricShow();
            wattsTextBox.ReadOnly = false;
            voltsTextBox.ReadOnly = false;
            ampsTextBox.Text = "Auto calculated";
            
        }

        private void refreshItems()
        {
            inventoryListBox.Items.Clear();
            foreach (HandTool entry in HandTools)
            {
                inventoryListBox.Items.Add(entry.Name);
            }

            foreach (ElectricTool entry in ElectricTools)
            {
                inventoryListBox.Items.Add(entry.Name);
            }

            foreach (PneumaticTool entry in PneumaticTools)
            {
                inventoryListBox.Items.Add(entry.Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (CheckIfFormOK() == true)
            {
                try
                {
                    ElectricTool thisElectricTool = new ElectricTool();
                    PneumaticTool thisPneumaticTool = new PneumaticTool();
                    HandTool thisHandTool = new HandTool();

                    if (typeTextBox.Text=="Hand Tool")
                    {
                        thisHandTool = new HandTool();
                        thisHandTool.Type = "Hand Tool";
                        thisHandTool.Name = nameTextBox.Text;
                        thisHandTool.Number = int.Parse(numberTextBox.Text);
                        thisHandTool.Make = makeTextBox.Text;
                        thisHandTool.Width = double.Parse(widthTextBox.Text);
                        thisHandTool.Height = double.Parse(heightTextBox.Text);
                        thisHandTool.Weight = double.Parse(weightTextBox.Text);
                        HandTools.Add(thisHandTool);
                    }

                    else if (typeTextBox.Text == "Pneumatic Tool")
                    {
                        if(editRadioButton.Checked)
                        {
                            mufflerTextBox.ReadOnly = false;
                            pressureTextBox.ReadOnly = false;
                        }
                        thisPneumaticTool = new PneumaticTool();
                        thisPneumaticTool.Type = "Pneumatic Tool";
                        thisPneumaticTool.Name = nameTextBox.Text;
                        thisPneumaticTool.Number = int.Parse(numberTextBox.Text);
                        thisPneumaticTool.Make = makeTextBox.Text;
                        thisPneumaticTool.Width = double.Parse(widthTextBox.Text);
                        thisPneumaticTool.Height = double.Parse(heightTextBox.Text);
                        thisPneumaticTool.Weight = double.Parse(weightTextBox.Text);
                        if(double.TryParse(pressureTextBox.Text,out double pressioin))
                        {
                            thisPneumaticTool.Pressure = pressioin;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Pression. Defaulted to 0");
                            thisPneumaticTool.Pressure = 0;
                        }
                        if (Boolean.TryParse(mufflerTextBox.Text, out bool muffler))
                        {
                            thisPneumaticTool.Muffler_Present = muffler;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Muffler presence. Defaulted to false");
                            thisPneumaticTool.Muffler_Present = false;
                        }
                        PneumaticTools.Add(thisPneumaticTool);
                    }
                    else if (typeTextBox.Text == "Electric Tool")
                    {
                        thisElectricTool = new ElectricTool();
                        thisElectricTool.Type = "Electric Tool";
                        thisElectricTool.Name = nameTextBox.Text;
                        thisElectricTool.Number = int.Parse(numberTextBox.Text);
                        thisElectricTool.Make = makeTextBox.Text;
                        thisElectricTool.Width = double.Parse(widthTextBox.Text);
                        thisElectricTool.Height = double.Parse(heightTextBox.Text);
                        thisElectricTool.Weight = double.Parse(weightTextBox.Text);
                        if(double.TryParse(wattsTextBox.Text,out double watts)&&double.TryParse(voltsTextBox.Text,out double volts))
                        {
                            thisElectricTool.Watts = watts;
                            thisElectricTool.Volts = volts;
                            thisElectricTool.Amps = watts / volts;
                        }
                        else
                        {
                            MessageBox.Show("Invalid Watts and/or Volts. Defaulted to 0");
                            thisElectricTool.Watts = 0;
                            thisElectricTool.Volts = 0;
                            thisElectricTool.Amps = 0;
                        }
                        ElectricTools.Add(thisElectricTool);
                    }
                    MessageBox.Show("Item successfully added.");
                    clear();
                    refreshItems();
                }
                catch
                {

                }
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            int index = inventoryListBox.SelectedIndex;

            if (CheckIfFormOK() == true)
            {
                try
                {
                    foreach(HandTool entry in HandTools)
                    {
                        if(inventoryListBox.SelectedItem.ToString()==entry.Name)
                        {
                            HandTools[index].Number = int.Parse(numberTextBox.Text);
                            HandTools[index].Name = nameTextBox.Text;
                            HandTools[index].Make = makeTextBox.Text;
                            HandTools[index].Width = double.Parse(widthTextBox.Text);
                            HandTools[index].Height = double.Parse(heightTextBox.Text);
                            HandTools[index].Weight = double.Parse(weightTextBox.Text);
                        }
                    }

                    foreach(ElectricTool entry in ElectricTools)
                    {
                        if(inventoryListBox.SelectedItem.ToString()==entry.Name)
                        {
                            int difference = index - HandTools.Count;
                            ElectricTools[difference].Number = int.Parse(numberTextBox.Text);
                            ElectricTools[difference].Name = nameTextBox.Text;
                            ElectricTools[difference].Make = makeTextBox.Text;
                            ElectricTools[difference].Width = double.Parse(widthTextBox.Text);
                            ElectricTools[difference].Height = double.Parse(heightTextBox.Text);
                            ElectricTools[difference].Weight = double.Parse(weightTextBox.Text);
                            ElectricTools[difference].Watts = double.Parse(wattsTextBox.Text);
                            ElectricTools[difference].Volts = double.Parse(voltsTextBox.Text);
                            ElectricTools[difference].Amps = ElectricTools[index - HandTools.Count].Watts / ElectricTools[index - HandTools.Count].Volts;
                        }
                    }

                    foreach(PneumaticTool entry in PneumaticTools)
                    {
                        if(inventoryListBox.SelectedItem.ToString()==entry.Name)
                        {
                            int difference = index - ElectricTools.Count -HandTools.Count;
                            PneumaticTools[difference].Number= int.Parse(numberTextBox.Text);
                            PneumaticTools[difference].Name= nameTextBox.Text;
                            PneumaticTools[difference].Make = makeTextBox.Text;
                            PneumaticTools[difference].Width= double.Parse(widthTextBox.Text);
                            PneumaticTools[difference].Height = double.Parse(heightTextBox.Text);
                            PneumaticTools[difference].Weight = double.Parse(weightTextBox.Text);
                            if(double.TryParse(pressureTextBox.Text, out double pressioin))
                            {
                                PneumaticTools[difference].Pressure = pressioin;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Pression. Defaulted to 0");
                                PneumaticTools[difference].Pressure = 0;
                            }
                            if (Boolean.TryParse(mufflerTextBox.Text, out bool muffler))
                            {
                                PneumaticTools[difference].Muffler_Present = muffler;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Muffler presence. Defaulted to false");
                                PneumaticTools[difference].Muffler_Present = false;
                            }
                        }
                    }
                    MessageBox.Show("Item successfully edited.");
                    refreshItems();
                    clear();
                }

                catch { }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            SaveFile();
            this.Close();
        }

        private void editRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (addRadioButton.Checked)
            {


                numberTextBox.ReadOnly = false;
                nameTextBox.ReadOnly = false;
                makeTextBox.ReadOnly = false;
                widthTextBox.ReadOnly = false;
                heightTextBox.ReadOnly = false;
                weightTextBox.ReadOnly = false;

                clear();

                handButton.Visible = true;
                electricButton.Visible = true;
                pneumaticButton.Visible = true;
                addButton.Visible = true;
                editButton.Visible = false;
            }
            else if (viewRadioButton.Checked)
            {
                clear();
                ViewMode();
                electricHide();
                pneumaticHide();
                handButton.Visible = false;
                electricButton.Visible = false;
                pneumaticButton.Visible = false;
                wattsTextBox.ReadOnly = true;
                voltsTextBox.ReadOnly = true;
                pressureTextBox.ReadOnly = true;
                mufflerTextBox.ReadOnly = true;
                addButton.Visible = false;
                editButton.Visible = false;
            }
            else if (editRadioButton.Checked)
            {
                numberTextBox.ReadOnly = false;
                nameTextBox.ReadOnly = false;
                makeTextBox.ReadOnly = false;
                widthTextBox.ReadOnly = false;
                heightTextBox.ReadOnly = false;
                weightTextBox.ReadOnly = false;

                clear();

                handButton.Visible = false;
                electricButton.Visible = false;
                pneumaticButton.Visible = false;
                addButton.Visible = false;
                editButton.Visible = true;
            }
        }
    }
}
