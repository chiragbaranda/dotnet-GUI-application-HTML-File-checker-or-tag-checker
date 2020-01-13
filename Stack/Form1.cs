///
/// Program: Form1.cs
/// 
/// Author: Chirag Baranda
/// 000759867
/// Date:   23 November 2018
/// I, Chirag Baranda, 000759867 certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// Purpose: This file contains code for the open , read , print  split and balance Html tags from  file

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

namespace Stack
{
    public partial class Form1 : Form
    {
        private string fileName;
        /// <summary>
        ///  Initialize form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// To exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// open dialog box to select file and open ONLY html extension file. 
        /// Also change the label with file name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileOpenMenu_Click(object sender, EventArgs e)
        {
            HTMLOpenFileDialog.Title = "Please Select HTML File";
            HTMLOpenFileDialog.Filter = "HTML Files (*.html, *.htm)|*.html; *.htm";
            if (HTMLOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                statusLabel.Text = HTMLOpenFileDialog.FileName;
                fileName = HTMLOpenFileDialog.FileName;
            }
            else
                statusLabel.Text = "You canceled this operation";
        }
        /// <summary>
        /// read the file and check tags if they are balanced or not (using stack) 
        /// also ignores (img,br,hr) tags 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void processCheckTagsMenu_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(fileName); // object of StramReader   
            Stack<string> tagStack = new Stack<string>(); //object of Stack<string>
            tagsListBox.Items.Clear();
            int spaceCount = 0;
            Char space = ' ';

            string line;
            string[] ignoreTags = {"br", "hr"}; // array of tags to be ignored
            string[] tagProprties = {"img", "input" , "table", "tr", "td" };
            while ((line = reader.ReadLine()) != null)          //read file to the end of file
            {
                int endPosition; //end position defined for substring
                int startPosition = line.IndexOf("<");    //start position for defining substring start with '<'
                if (startPosition != -1)                //if compiler do not file < , it will return 
                {
                    endPosition = line.IndexOf(">");                //get end-position for substring, position of  >
                    string tag = line.Substring(startPosition + 1, endPosition - startPosition - 1); //recognize a tag

                    if (tag[0] != '/')              //if tag is not getting over then only
                    {
                        if (!ignoreTags.Contains(tag))          //compare with the array of the tags to be ignored, if match with any of the tag from ignored tag will not add it to the list
                        {
                            //if fount img - just print on console
                            if (tag.Contains("img"))
                            {
                                tag = tag.Substring(0, 3);
                                tagsListBox.Items.Add(new String(space, tagStack.Count) + "Found Non-Coninater Tag : <"+tag+">");
                            }
                            else if(tag.Contains("table")) //if found table; make substring and add it to stack
                            {
                                spaceCount++;
                                tag = tag.Substring(0, 5);
                                tagStack.Push(tag);
                                tagsListBox.Items.Add(new String(space, tagStack.Count) + "Found Non-Coninater Tag : <"+tag + ">");
                            }
                            else if (tag.Contains("tr")) //if found tr; make substring and add it to stack
                            {
                                spaceCount++;
                                tag = tag.Substring(0, 2);
                                tagStack.Push(tag);
                                tagsListBox.Items.Add(new String(space, tagStack.Count) + "Found Non-Coninater Tag : <"+tag + ">");
                            }
                            else if (tag.Contains("td")) //if found td; make substring and add it to stack
                            {
                                spaceCount++;
                                tag = tag.Substring(0, 2);
                                tagStack.Push(tag);
                                tagsListBox.Items.Add(new String(space, tagStack.Count) + "Found Non-Coninater Tag : <"+ tag + ">");
                            }
                            /*
                            else if(tagProprties.Contains(tag)) //if found properties after the ath; make substring and add it to stack
                            {
                                int start = tag.IndexOf("%")+1;
                                int spaceLocation = tag.IndexOf(" ", StartPosition);
                                tag = tag.Substring(0, spaceLocation);
                                tagsListBox.Items.Add("Found Non-Coninater Tag :" + tag);

                            }*/
                            /*else if ("table".Equals(tag.Substring(0, 6).Trim('\r').Trim('\n').Trim()))
                            {
                                tagsListBox.Items.Add("substring: " + tag.Substring(0, 4));
                                tagStack.Push("table");
                                tagsListBox.Items.Add("Found opening Tag : table");
                            }
                            else*/
                            else if (tag[0] == 'a') //if found a; make substring and add it to stack
                            {
                                spaceCount++;
                                tag = tag.Substring(0, 1);
                                tagStack.Push(tag);
                                tagsListBox.Items.Add(new String(space, spaceCount) + "Found Openig Tag : <"+ tag + ">");
                                
                            }
                            else
                            {
                                spaceCount++;
                                tagStack.Push(tag);
                                tagsListBox.Items.Add(new String(space, spaceCount) + "Found Openig Tag: <" + tag + ">");
                               
                            }
                        }                                                              
                        else
                            tagsListBox.Items.Add(new String(space, spaceCount) + "Found Non - Coninater Tag: <" + tag + ">");
                    }
                    else    
                    {       //code if closing tag found in a string

                        
                        tagsListBox.Items.Add(new String(space, spaceCount) + "Found Closing Tag: <" + tag + ">");
                        if (tagStack.Pop() != tag.Substring(1))     //check if value from the top of the satck mactch with the value to be matched i.e. closing tag name with '/'
                        {
                            statusLabel.Text = "Tags are not balanced";
                            break;
                        }
                        spaceCount--;
                    }
                    
                }
                else
                {
                    startPosition++;//define the end position to the 'start position of next string'
                }
                
            }

            reader.Close(); //close the file

            //check for the stack count
            // if the stack count is 0 then all tags are blanced
            //if not tags are not balanced
            if (tagStack.Count == 0)
                statusLabel.Text = "Tags are balanced";
            else
                statusLabel.Text = "Tags are not balanced";
        }
    }
    
}
