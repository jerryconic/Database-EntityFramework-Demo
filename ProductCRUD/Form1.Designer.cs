namespace ProductCRUD;

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
        label1 = new Label();
        txtId = new TextBox();
        txtName = new TextBox();
        label2 = new Label();
        txtPrice = new TextBox();
        label3 = new Label();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnSelect = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(116, 63);
        label1.Name = "label1";
        label1.Size = new Size(184, 41);
        label1.TabIndex = 0;
        label1.Text = "Product ID:";
        // 
        // txtId
        // 
        txtId.Location = new Point(322, 56);
        txtId.Name = "txtId";
        txtId.Size = new Size(321, 48);
        txtId.TabIndex = 1;
        // 
        // txtName
        // 
        txtName.Location = new Point(322, 143);
        txtName.Name = "txtName";
        txtName.Size = new Size(321, 48);
        txtName.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(57, 146);
        label2.Name = "label2";
        label2.Size = new Size(243, 41);
        label2.TabIndex = 2;
        label2.Text = "Product Name:";
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(322, 240);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(321, 48);
        txtPrice.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(202, 243);
        label3.Name = "label3";
        label3.Size = new Size(98, 41);
        label3.TabIndex = 4;
        label3.Text = "Price:";
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(63, 354);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(170, 57);
        btnAdd.TabIndex = 6;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(257, 354);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(170, 57);
        btnUpdate.TabIndex = 7;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(453, 354);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(170, 57);
        btnDelete.TabIndex = 8;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnSelect
        // 
        btnSelect.Location = new Point(667, 51);
        btnSelect.Name = "btnSelect";
        btnSelect.Size = new Size(170, 57);
        btnSelect.TabIndex = 9;
        btnSelect.Text = "Select";
        btnSelect.UseVisualStyleBackColor = true;
        btnSelect.Click += btnSelect_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(19F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1090, 510);
        Controls.Add(btnSelect);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnAdd);
        Controls.Add(txtPrice);
        Controls.Add(label3);
        Controls.Add(txtName);
        Controls.Add(label2);
        Controls.Add(txtId);
        Controls.Add(label1);
        Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
        Margin = new Padding(4);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtId;
    private TextBox txtName;
    private Label label2;
    private TextBox txtPrice;
    private Label label3;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnSelect;
}
