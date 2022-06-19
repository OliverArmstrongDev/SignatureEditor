using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using SignatureEditor.Properties;
using System.Globalization;

namespace SignatureEditor
{
    public partial class MainForm : Form
    {
        List<string> _sig = new List<string>();
        bool errorMsgTriggered = false;
        string saveFileName, _year, _serverSigPath, _newSignaturePath, _localSigPath,_newSigImages;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            ReadSignatureTemplate();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            _year = Settings.Default.YearOfSignature;
            _localSigPath = Settings.Default.ServerSigLocation;
            _serverSigPath = Settings.Default.ServerSigLocation;
            _newSignaturePath = Settings.Default.NewSigLocation;
            _newSigImages = Settings.Default.NewSigImages;
            
        }
        private void WriteNewSignature(List<string> NewSig)
        {
            try
            {
                saveFileName = txtLname.Text.Remove(1); 
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < _sig.Count; i++)
                {
                    sb.AppendLine(this._sig[i].ToString());
                }
                
                using (StreamWriter outfile = new StreamWriter(_serverSigPath + _year + "_" + this.txtFname.Text + saveFileName + ".htm"))
                {
                    outfile.Write(sb.ToString());                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); 
            }
            finally 
            {
                if (File.Exists(_serverSigPath + _year + "_" + this.txtFname.Text + saveFileName + ".htm"))
                {
                    if (copySignatureToLocalProfile())
                    {
                        MessageBox.Show("The Signature has been created successfully!\r\nThis program will now close.", "Signature Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show("There was an error copying the signature to the local computer!\r\nContact IT Support for help.\r\n\nThis program will now close.", "Signature Not Created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Environment.Exit(1);
                    }
                }
            }
        }
        private bool copySignatureToLocalProfile()
        {
            string usr = Environment.UserName;
            string usrProfile = @"C:\Documents and Settings\"+usr+ @"\Application Data\Microsoft\Signatures\";

            try
            {
                if (File.Exists(_serverSigPath + _year + "_" + this.txtFname.Text + saveFileName + ".htm"))
                {
                    File.Copy(_serverSigPath + _year + "_" + this.txtFname.Text + saveFileName + ".htm", usrProfile +
                        _year + "_" + this.txtFname.Text + saveFileName + ".htm", true);


                    string[] files = Directory.GetFiles(_newSigImages);
                    foreach (string s in files)
                    {
                        string fileName = Path.GetFileName(s);
                        string destFile = Path.Combine(usrProfile, fileName);
                        File.Copy(s, destFile, true);


                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }
        private void validationMessage(string _msg)
        {
            //set bool to true
            errorMsgTriggered = true;
            //clear list
            _sig.Clear();
            MessageBox.Show(_msg, "Details Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
        }
        private void ReadSignatureTemplate()
        {
            try
            {
                string filePath = _newSignaturePath + "new_signature.htm";
                string line;

                if (File.Exists(filePath))
                {
                    StreamReader file = null;
                    try
                    {
                        file = new StreamReader(filePath);
                        while ((line = file.ReadLine()) != null)
                        {
                            if (line.Contains("FirstnameLastname"))
                            {
                                if (this.txtFname.Text != "" && this.txtLname.Text != "")
                                {
                                    var names = line.Replace("FirstnameLastname", this.txtFname.Text + " " + this.txtLname.Text);
                                    _sig.Add(names);
                                }
                                else { validationMessage("A First and Last name is required."); break; }

                            }
                            else if (line.Contains("JobTitle"))
                            {
                                if (this.txtJobTitle.Text != "")
                                {
                                    var jobTitle = line.Replace("JobTitle", this.txtJobTitle.Text);
                                    _sig.Add(jobTitle);
                                }
                                else { validationMessage("A Job Title is required."); break; }

                            }
                            else if (line.Contains("Phone:"))
                            {
                                if (this.txtPhone.Text != "")
                                {
                                    if (validatePhoneNumbers(this.txtPhone.Text))
                                    {
                                        var phne = line.Replace("(07) 3371 7229", "(07) " + this.txtPhone.Text);
                                        _sig.Add(phne);
                                    }
                                    else { validationMessage("A valid Phone number is required.\r\n"+ 
                                        "In the following format: 1234 5678"); break; }
                                }
                                else { validationMessage("A Phone number is required."); break; }

                            }
                            else if (line.Contains("Mob:"))
                            {
                                if (this.txtMob.Text != "")
                                {
                                    if (validatePhoneNumbers(this.txtMob.Text))
                                    {
                                        var remComments1 = line.Remove(0, 5);
                                        var remComments2 = remComments1.Remove(remComments1.Length - 3, 3);
                                        var mobile = remComments2.Replace("0412 345 678", this.txtMob.Text);
                                        _sig.Add(mobile);
                                    }
                                    else { validationMessage("A valid Mobile number is required.\r\n"+ 
                                        "In the following format: 1234 5678"); break; }
                                }
                            }
                            else if (line.Contains("Fax:"))
                            {
                                if (this.txtFax.Text != "")
                                {
                                    if (validatePhoneNumbers(this.txtFax.Text))
                                    {
                                        var fax = line.Replace("(07) 3371 7229", "(07) " + this.txtFax.Text);
                                        _sig.Add(fax);
                                    }
                                    else { validationMessage("A valid Fax number is required."); break; }
                                }
                                else { _sig.Add(line); }
                            }
                            else if (line.Contains("Email:"))
                            {
                                if (this.txtEmail.Text != "")
                                {
                                    if (validateEmailAddress(this.txtEmail.Text))
                                    {
                                        var email = line.Replace("info@uqs.com.au", this.txtEmail.Text);
                                        _sig.Add(email);
                                    }
                                    else { validationMessage("A valid Email address is required"); break; }
                                }
                                else { validationMessage("An Email address is required"); break; }
                            }
                            else
                            {
                                _sig.Add(line);
                            }
                        }
                        if (errorMsgTriggered != true) { WriteNewSignature(_sig); }
                    }
                    finally
                    {
                        errorMsgTriggered = false;
                        if (file != null)
                            file.Close();
                    }
                }
                else { MessageBox.Show("Email template \"new_signature.htm\" not found","Template not found!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private bool validateEmailAddress(string emailAddress)
        {
           
          string patternStrict = @"^(([^<>()[\]\\.,;:\s@\""]+"

                + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"

                + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"

                + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"

                + @"[a-zA-Z]{2,}))$";

          Regex reStrict = new Regex(patternStrict);

                bool isStrictMatch = reStrict.IsMatch(emailAddress);

                return isStrictMatch;
            
        }
        private bool validatePhoneNumbers(string phoneNumber)
        {
            string patternStrict = @"^\d{4} [0-9]{4}$";//@"^\d\s+$"; @"^\d{1}-[0-9a-zA-Z]{6}$"

            Regex reStrict = new Regex(patternStrict);

            bool isStrictMatch = reStrict.IsMatch(phoneNumber);
               
            return isStrictMatch;
        }
    }
}
