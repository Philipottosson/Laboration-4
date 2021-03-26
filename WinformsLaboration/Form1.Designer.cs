
using System;

namespace WinformsLaboration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.label_InLanguages = new System.Windows.Forms.Label();
            this.txt_word = new System.Windows.Forms.TextBox();
            this.label_WordOrTranslation = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.grp_menu = new System.Windows.Forms.GroupBox();
            this.btn_menuAdd = new System.Windows.Forms.Button();
            this.btn_practice = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_menuRemove = new System.Windows.Forms.Button();
            this.grp_practice = new System.Windows.Forms.GroupBox();
            this.Label_answer = new System.Windows.Forms.Label();
            this.btn_generateWord = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_practiceAnswer = new System.Windows.Forms.TextBox();
            this.txt_practiceTo = new System.Windows.Forms.TextBox();
            this.txt_practiceFrom = new System.Windows.Forms.TextBox();
            this.btn_PracticeCheck = new System.Windows.Forms.Button();
            this.txt_listAll = new System.Windows.Forms.TextBox();
            this.txt_listLanguages = new System.Windows.Forms.TextBox();
            this.Label_listLanguages = new System.Windows.Forms.Label();
            this.grp_list = new System.Windows.Forms.GroupBox();
            this.txt_sortByLanguages = new System.Windows.Forms.TextBox();
            this.btn_listBylanguage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_removeWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_remove = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_removeLanguages = new System.Windows.Forms.TextBox();
            this.grp_createNewList = new System.Windows.Forms.GroupBox();
            this.btn_CreateFile = new System.Windows.Forms.Button();
            this.btn_addLanguages = new System.Windows.Forms.Button();
            this.txt_CreateNewList = new System.Windows.Forms.TextBox();
            this.label_NewListLanguages = new System.Windows.Forms.Label();
            this.grp_add = new System.Windows.Forms.GroupBox();
            this.grp_menu.SuspendLayout();
            this.grp_practice.SuspendLayout();
            this.grp_list.SuspendLayout();
            this.grp_remove.SuspendLayout();
            this.grp_createNewList.SuspendLayout();
            this.grp_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(90, 63);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(68, 23);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(90, 21);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(201, 23);
            this.txt_filename.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 24);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(55, 15);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Filename";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(223, 63);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(68, 23);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label_InLanguages
            // 
            this.label_InLanguages.AutoSize = true;
            this.label_InLanguages.Location = new System.Drawing.Point(121, 33);
            this.label_InLanguages.Name = "label_InLanguages";
            this.label_InLanguages.Size = new System.Drawing.Size(64, 15);
            this.label_InLanguages.TabIndex = 3;
            this.label_InLanguages.Text = "Languages";
            // 
            // txt_word
            // 
            this.txt_word.Location = new System.Drawing.Point(16, 52);
            this.txt_word.Name = "txt_word";
            this.txt_word.Size = new System.Drawing.Size(178, 23);
            this.txt_word.TabIndex = 1;
            // 
            // label_WordOrTranslation
            // 
            this.label_WordOrTranslation.AutoSize = true;
            this.label_WordOrTranslation.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label_WordOrTranslation.Location = new System.Drawing.Point(16, 33);
            this.label_WordOrTranslation.Name = "label_WordOrTranslation";
            this.label_WordOrTranslation.Size = new System.Drawing.Size(49, 15);
            this.label_WordOrTranslation.TabIndex = 3;
            this.label_WordOrTranslation.Text = "Word in";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // grp_menu
            // 
            this.grp_menu.Controls.Add(this.btn_menuAdd);
            this.grp_menu.Controls.Add(this.btn_practice);
            this.grp_menu.Controls.Add(this.btn_list);
            this.grp_menu.Controls.Add(this.btn_menuRemove);
            this.grp_menu.Location = new System.Drawing.Point(12, 101);
            this.grp_menu.Name = "grp_menu";
            this.grp_menu.Size = new System.Drawing.Size(368, 108);
            this.grp_menu.TabIndex = 3;
            this.grp_menu.TabStop = false;
            this.grp_menu.Visible = false;
            // 
            // btn_menuAdd
            // 
            this.btn_menuAdd.Location = new System.Drawing.Point(16, 33);
            this.btn_menuAdd.Name = "btn_menuAdd";
            this.btn_menuAdd.Size = new System.Drawing.Size(70, 38);
            this.btn_menuAdd.TabIndex = 4;
            this.btn_menuAdd.Text = "Add words";
            this.btn_menuAdd.UseVisualStyleBackColor = true;
            this.btn_menuAdd.Click += new System.EventHandler(this.btn_menuAdd_Click);
            // 
            // btn_practice
            // 
            this.btn_practice.Location = new System.Drawing.Point(198, 33);
            this.btn_practice.Name = "btn_practice";
            this.btn_practice.Size = new System.Drawing.Size(68, 38);
            this.btn_practice.TabIndex = 0;
            this.btn_practice.Text = "Practice";
            this.btn_practice.UseVisualStyleBackColor = true;
            this.btn_practice.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(285, 33);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(68, 38);
            this.btn_list.TabIndex = 0;
            this.btn_list.Text = "List words";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_menuRemove
            // 
            this.btn_menuRemove.Location = new System.Drawing.Point(105, 33);
            this.btn_menuRemove.Name = "btn_menuRemove";
            this.btn_menuRemove.Size = new System.Drawing.Size(68, 38);
            this.btn_menuRemove.TabIndex = 0;
            this.btn_menuRemove.Text = "Remove words";
            this.btn_menuRemove.UseVisualStyleBackColor = true;
            this.btn_menuRemove.Click += new System.EventHandler(this.btn_menuRemove_Click);
            // 
            // grp_practice
            // 
            this.grp_practice.Controls.Add(this.Label_answer);
            this.grp_practice.Controls.Add(this.btn_generateWord);
            this.grp_practice.Controls.Add(this.label5);
            this.grp_practice.Controls.Add(this.label7);
            this.grp_practice.Controls.Add(this.label6);
            this.grp_practice.Controls.Add(this.txt_practiceAnswer);
            this.grp_practice.Controls.Add(this.txt_practiceTo);
            this.grp_practice.Controls.Add(this.txt_practiceFrom);
            this.grp_practice.Controls.Add(this.btn_PracticeCheck);
            this.grp_practice.Location = new System.Drawing.Point(12, 209);
            this.grp_practice.Name = "grp_practice";
            this.grp_practice.Size = new System.Drawing.Size(368, 364);
            this.grp_practice.TabIndex = 3;
            this.grp_practice.TabStop = false;
            this.grp_practice.Visible = false;
            // 
            // Label_answer
            // 
            this.Label_answer.AutoSize = true;
            this.Label_answer.Location = new System.Drawing.Point(19, 297);
            this.Label_answer.Name = "Label_answer";
            this.Label_answer.Size = new System.Drawing.Size(88, 15);
            this.Label_answer.TabIndex = 4;
            this.Label_answer.Text = "Correct Answer";
            this.Label_answer.Visible = false;
            // 
            // btn_generateWord
            // 
            this.btn_generateWord.Location = new System.Drawing.Point(150, 22);
            this.btn_generateWord.Name = "btn_generateWord";
            this.btn_generateWord.Size = new System.Drawing.Size(68, 38);
            this.btn_generateWord.TabIndex = 0;
            this.btn_generateWord.Text = "Practice";
            this.btn_generateWord.UseVisualStyleBackColor = true;
            this.btn_generateWord.Click += new System.EventHandler(this.btn_generateWord_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Word";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Your answer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tramslate to language";
            // 
            // txt_practiceAnswer
            // 
            this.txt_practiceAnswer.Location = new System.Drawing.Point(16, 220);
            this.txt_practiceAnswer.Name = "txt_practiceAnswer";
            this.txt_practiceAnswer.Size = new System.Drawing.Size(178, 23);
            this.txt_practiceAnswer.TabIndex = 1;
            // 
            // txt_practiceTo
            // 
            this.txt_practiceTo.Location = new System.Drawing.Point(16, 134);
            this.txt_practiceTo.Name = "txt_practiceTo";
            this.txt_practiceTo.ReadOnly = true;
            this.txt_practiceTo.Size = new System.Drawing.Size(178, 23);
            this.txt_practiceTo.TabIndex = 1;
            // 
            // txt_practiceFrom
            // 
            this.txt_practiceFrom.Location = new System.Drawing.Point(16, 90);
            this.txt_practiceFrom.Name = "txt_practiceFrom";
            this.txt_practiceFrom.ReadOnly = true;
            this.txt_practiceFrom.Size = new System.Drawing.Size(178, 23);
            this.txt_practiceFrom.TabIndex = 1;
            // 
            // btn_PracticeCheck
            // 
            this.btn_PracticeCheck.Location = new System.Drawing.Point(209, 219);
            this.btn_PracticeCheck.Name = "btn_PracticeCheck";
            this.btn_PracticeCheck.Size = new System.Drawing.Size(99, 23);
            this.btn_PracticeCheck.TabIndex = 0;
            this.btn_PracticeCheck.Text = "Check answer";
            this.btn_PracticeCheck.UseVisualStyleBackColor = true;
            this.btn_PracticeCheck.Click += new System.EventHandler(this.btn_PracticeCheck_Click);
            // 
            // txt_listAll
            // 
            this.txt_listAll.Location = new System.Drawing.Point(6, 155);
            this.txt_listAll.Multiline = true;
            this.txt_listAll.Name = "txt_listAll";
            this.txt_listAll.ReadOnly = true;
            this.txt_listAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_listAll.Size = new System.Drawing.Size(347, 197);
            this.txt_listAll.TabIndex = 1;
            // 
            // txt_listLanguages
            // 
            this.txt_listLanguages.Location = new System.Drawing.Point(6, 113);
            this.txt_listLanguages.Name = "txt_listLanguages";
            this.txt_listLanguages.ReadOnly = true;
            this.txt_listLanguages.Size = new System.Drawing.Size(347, 23);
            this.txt_listLanguages.TabIndex = 4;
            // 
            // Label_listLanguages
            // 
            this.Label_listLanguages.AutoSize = true;
            this.Label_listLanguages.Location = new System.Drawing.Point(6, 92);
            this.Label_listLanguages.Name = "Label_listLanguages";
            this.Label_listLanguages.Size = new System.Drawing.Size(64, 15);
            this.Label_listLanguages.TabIndex = 2;
            this.Label_listLanguages.Text = "Languages";
            // 
            // grp_list
            // 
            this.grp_list.Controls.Add(this.txt_sortByLanguages);
            this.grp_list.Controls.Add(this.txt_listAll);
            this.grp_list.Controls.Add(this.txt_listLanguages);
            this.grp_list.Controls.Add(this.btn_listBylanguage);
            this.grp_list.Controls.Add(this.label3);
            this.grp_list.Controls.Add(this.Label_listLanguages);
            this.grp_list.Location = new System.Drawing.Point(12, 215);
            this.grp_list.Name = "grp_list";
            this.grp_list.Size = new System.Drawing.Size(368, 358);
            this.grp_list.TabIndex = 5;
            this.grp_list.TabStop = false;
            this.grp_list.Visible = false;
            // 
            // txt_sortByLanguages
            // 
            this.txt_sortByLanguages.Location = new System.Drawing.Point(6, 45);
            this.txt_sortByLanguages.Name = "txt_sortByLanguages";
            this.txt_sortByLanguages.Size = new System.Drawing.Size(140, 23);
            this.txt_sortByLanguages.TabIndex = 5;
            // 
            // btn_listBylanguage
            // 
            this.btn_listBylanguage.Location = new System.Drawing.Point(198, 44);
            this.btn_listBylanguage.Name = "btn_listBylanguage";
            this.btn_listBylanguage.Size = new System.Drawing.Size(68, 23);
            this.btn_listBylanguage.TabIndex = 0;
            this.btn_listBylanguage.Text = "List";
            this.btn_listBylanguage.UseVisualStyleBackColor = true;
            this.btn_listBylanguage.Click += new System.EventHandler(this.btn_listBylanguage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "List by language";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(16, 165);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(70, 23);
            this.btn_remove.TabIndex = 0;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txt_removeWord
            // 
            this.txt_removeWord.Location = new System.Drawing.Point(16, 46);
            this.txt_removeWord.Name = "txt_removeWord";
            this.txt_removeWord.Size = new System.Drawing.Size(263, 23);
            this.txt_removeWord.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Word";
            // 
            // grp_remove
            // 
            this.grp_remove.Controls.Add(this.label8);
            this.grp_remove.Controls.Add(this.label4);
            this.grp_remove.Controls.Add(this.txt_removeLanguages);
            this.grp_remove.Controls.Add(this.txt_removeWord);
            this.grp_remove.Controls.Add(this.btn_remove);
            this.grp_remove.Location = new System.Drawing.Point(12, 219);
            this.grp_remove.Name = "grp_remove";
            this.grp_remove.Size = new System.Drawing.Size(368, 219);
            this.grp_remove.TabIndex = 3;
            this.grp_remove.TabStop = false;
            this.grp_remove.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Languages";
            // 
            // txt_removeLanguages
            // 
            this.txt_removeLanguages.Location = new System.Drawing.Point(16, 112);
            this.txt_removeLanguages.Name = "txt_removeLanguages";
            this.txt_removeLanguages.Size = new System.Drawing.Size(263, 23);
            this.txt_removeLanguages.TabIndex = 1;
            // 
            // grp_createNewList
            // 
            this.grp_createNewList.Controls.Add(this.btn_CreateFile);
            this.grp_createNewList.Controls.Add(this.btn_addLanguages);
            this.grp_createNewList.Controls.Add(this.txt_CreateNewList);
            this.grp_createNewList.Controls.Add(this.label_NewListLanguages);
            this.grp_createNewList.Location = new System.Drawing.Point(12, 101);
            this.grp_createNewList.Name = "grp_createNewList";
            this.grp_createNewList.Size = new System.Drawing.Size(368, 127);
            this.grp_createNewList.TabIndex = 3;
            this.grp_createNewList.TabStop = false;
            this.grp_createNewList.Visible = false;
            // 
            // btn_CreateFile
            // 
            this.btn_CreateFile.Location = new System.Drawing.Point(16, 89);
            this.btn_CreateFile.Name = "btn_CreateFile";
            this.btn_CreateFile.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateFile.TabIndex = 6;
            this.btn_CreateFile.Text = "Create File";
            this.btn_CreateFile.UseVisualStyleBackColor = true;
            this.btn_CreateFile.Click += new System.EventHandler(this.btn_CreateFile_Click);
            // 
            // btn_addLanguages
            // 
            this.btn_addLanguages.Location = new System.Drawing.Point(244, 48);
            this.btn_addLanguages.Name = "btn_addLanguages";
            this.btn_addLanguages.Size = new System.Drawing.Size(114, 25);
            this.btn_addLanguages.TabIndex = 5;
            this.btn_addLanguages.Text = "Add Language";
            this.btn_addLanguages.UseVisualStyleBackColor = true;
            this.btn_addLanguages.Click += new System.EventHandler(this.btn_addLanguages_Click);
            // 
            // txt_CreateNewList
            // 
            this.txt_CreateNewList.Location = new System.Drawing.Point(16, 50);
            this.txt_CreateNewList.Name = "txt_CreateNewList";
            this.txt_CreateNewList.Size = new System.Drawing.Size(222, 23);
            this.txt_CreateNewList.TabIndex = 4;
            // 
            // label_NewListLanguages
            // 
            this.label_NewListLanguages.AutoSize = true;
            this.label_NewListLanguages.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label_NewListLanguages.Location = new System.Drawing.Point(16, 28);
            this.label_NewListLanguages.Name = "label_NewListLanguages";
            this.label_NewListLanguages.Size = new System.Drawing.Size(64, 15);
            this.label_NewListLanguages.TabIndex = 3;
            this.label_NewListLanguages.Text = "Languages";
            // 
            // grp_add
            // 
            this.grp_add.Controls.Add(this.label_InLanguages);
            this.grp_add.Controls.Add(this.button5);
            this.grp_add.Controls.Add(this.label_WordOrTranslation);
            this.grp_add.Controls.Add(this.txt_word);
            this.grp_add.Location = new System.Drawing.Point(12, 225);
            this.grp_add.Name = "grp_add";
            this.grp_add.Size = new System.Drawing.Size(368, 100);
            this.grp_add.TabIndex = 6;
            this.grp_add.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 591);
            this.Controls.Add(this.grp_practice);
            this.Controls.Add(this.grp_add);
            this.Controls.Add(this.grp_remove);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.grp_menu);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.grp_list);
            this.Controls.Add(this.grp_createNewList);
            this.MaximumSize = new System.Drawing.Size(410, 630);
            this.MinimumSize = new System.Drawing.Size(410, 630);
            this.Name = "Form1";
            this.Text = "Wordlist";
            this.Load += new System.EventHandler(this.Wordlist_Load);
            this.grp_menu.ResumeLayout(false);
            this.grp_practice.ResumeLayout(false);
            this.grp_practice.PerformLayout();
            this.grp_list.ResumeLayout(false);
            this.grp_list.PerformLayout();
            this.grp_remove.ResumeLayout(false);
            this.grp_remove.PerformLayout();
            this.grp_createNewList.ResumeLayout(false);
            this.grp_createNewList.PerformLayout();
            this.grp_add.ResumeLayout(false);
            this.grp_add.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.GroupBox grp_menu;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_menuRemove;
        private System.Windows.Forms.TextBox txt_word;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_listLanguages;
        private System.Windows.Forms.Label Label_listLanguages;
        private System.Windows.Forms.GroupBox grp_list;
        private System.Windows.Forms.Button btn_practice;
        private System.Windows.Forms.GroupBox grp_practice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_generateWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_practiceTo;
        private System.Windows.Forms.TextBox txt_practiceFrom;
        private System.Windows.Forms.TextBox txt_practiceAnswer;
        private System.Windows.Forms.Label Label_answer;
        private System.Windows.Forms.Button btn_PracticeCheck;
        private System.Windows.Forms.TextBox txt_listAll;
        private System.Windows.Forms.TextBox txt_sortByLanguages;
        private System.Windows.Forms.Button btn_listBylanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txt_removeWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grp_remove;
        private System.Windows.Forms.TextBox txt_removeLanguages;
        private System.Windows.Forms.Label label_WordOrTranslation;
        private System.Windows.Forms.Label label_InLanguages;
        private System.Windows.Forms.GroupBox grp_createNewList;
        private System.Windows.Forms.Label label_NewListLanguages;
        private System.Windows.Forms.Button btn_addLanguages;
        private System.Windows.Forms.TextBox txt_CreateNewList;
        private System.Windows.Forms.Button btn_CreateFile;
        private System.Windows.Forms.Button btn_menuAdd;
        private System.Windows.Forms.GroupBox grp_add;
    }
}

