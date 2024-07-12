namespace PizzaProject
{
    partial class PizzaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaMenu));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLargePizza = new System.Windows.Forms.RadioButton();
            this.rbMediumPizza = new System.Windows.Forms.RadioButton();
            this.rbSmallPizza = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThick = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkPapperoni = new System.Windows.Forms.CheckBox();
            this.chkBBQ = new System.Windows.Forms.CheckBox();
            this.chkMeat = new System.Windows.Forms.CheckBox();
            this.chkLibnah = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkHotDogs = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbPlaceOfEating = new System.Windows.Forms.GroupBox();
            this.rbOutSide = new System.Windows.Forms.RadioButton();
            this.rbInside = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSumSummary = new System.Windows.Forms.Label();
            this.lblPlaceSummary = new System.Windows.Forms.Label();
            this.lblToppingsSummary = new System.Windows.Forms.Label();
            this.lblCrustTypeSummary = new System.Windows.Forms.Label();
            this.lblSizeSummary = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetOrder = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbPlaceOfEating.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Teal;
            this.gbSize.Controls.Add(this.rbLargePizza);
            this.gbSize.Controls.Add(this.rbMediumPizza);
            this.gbSize.Controls.Add(this.rbSmallPizza);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Location = new System.Drawing.Point(148, 151);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(229, 152);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "The Size Of Pizzas";
            this.gbSize.Enter += new System.EventHandler(this.gbSize_Enter);
            // 
            // rbLargePizza
            // 
            this.rbLargePizza.AutoSize = true;
            this.rbLargePizza.Location = new System.Drawing.Point(6, 73);
            this.rbLargePizza.Name = "rbLargePizza";
            this.rbLargePizza.Size = new System.Drawing.Size(63, 20);
            this.rbLargePizza.TabIndex = 9;
            this.rbLargePizza.Text = "Large";
            this.rbLargePizza.UseVisualStyleBackColor = true;
            this.rbLargePizza.CheckedChanged += new System.EventHandler(this.rbLargePizza_CheckedChanged);
            // 
            // rbMediumPizza
            // 
            this.rbMediumPizza.AutoSize = true;
            this.rbMediumPizza.Location = new System.Drawing.Point(6, 47);
            this.rbMediumPizza.Name = "rbMediumPizza";
            this.rbMediumPizza.Size = new System.Drawing.Size(76, 20);
            this.rbMediumPizza.TabIndex = 8;
            this.rbMediumPizza.Text = "Medium";
            this.rbMediumPizza.UseVisualStyleBackColor = true;
            this.rbMediumPizza.CheckedChanged += new System.EventHandler(this.rbMediumPizza_CheckedChanged);
            // 
            // rbSmallPizza
            // 
            this.rbSmallPizza.AutoSize = true;
            this.rbSmallPizza.Checked = true;
            this.rbSmallPizza.Location = new System.Drawing.Point(6, 21);
            this.rbSmallPizza.Name = "rbSmallPizza";
            this.rbSmallPizza.Size = new System.Drawing.Size(62, 20);
            this.rbSmallPizza.TabIndex = 7;
            this.rbSmallPizza.TabStop = true;
            this.rbSmallPizza.Text = "Small";
            this.rbSmallPizza.UseVisualStyleBackColor = true;
            this.rbSmallPizza.CheckedChanged += new System.EventHandler(this.rbSmallPizza_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.BackColor = System.Drawing.Color.Teal;
            this.gbCrustType.Controls.Add(this.rbThick);
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCrustType.Location = new System.Drawing.Point(154, 346);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(229, 152);
            this.gbCrustType.TabIndex = 1;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "The Type Of Crust";
            this.gbCrustType.Enter += new System.EventHandler(this.gbCrustType_Enter);
            // 
            // rbThick
            // 
            this.rbThick.AutoSize = true;
            this.rbThick.Location = new System.Drawing.Point(6, 60);
            this.rbThick.Name = "rbThick";
            this.rbThick.Size = new System.Drawing.Size(61, 20);
            this.rbThick.TabIndex = 1;
            this.rbThick.Text = "Thick";
            this.rbThick.UseVisualStyleBackColor = true;
            this.rbThick.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(6, 34);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(54, 20);
            this.rbThin.TabIndex = 0;
            this.rbThin.Text = "Thin";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Teal;
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkPapperoni);
            this.gbToppings.Controls.Add(this.chkBBQ);
            this.gbToppings.Controls.Add(this.chkMeat);
            this.gbToppings.Controls.Add(this.chkLibnah);
            this.gbToppings.Controls.Add(this.chkChicken);
            this.gbToppings.Controls.Add(this.chkHotDogs);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.Location = new System.Drawing.Point(504, 151);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(229, 152);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            this.gbToppings.Enter += new System.EventHandler(this.gbToppings_Enter);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(120, 113);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 7;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkPapperoni
            // 
            this.chkPapperoni.AutoSize = true;
            this.chkPapperoni.Location = new System.Drawing.Point(120, 87);
            this.chkPapperoni.Name = "chkPapperoni";
            this.chkPapperoni.Size = new System.Drawing.Size(92, 20);
            this.chkPapperoni.TabIndex = 6;
            this.chkPapperoni.Text = "Papperoni";
            this.chkPapperoni.UseVisualStyleBackColor = true;
            this.chkPapperoni.CheckedChanged += new System.EventHandler(this.chkPapperoni_CheckedChanged);
            // 
            // chkBBQ
            // 
            this.chkBBQ.AutoSize = true;
            this.chkBBQ.Location = new System.Drawing.Point(120, 61);
            this.chkBBQ.Name = "chkBBQ";
            this.chkBBQ.Size = new System.Drawing.Size(99, 20);
            this.chkBBQ.TabIndex = 5;
            this.chkBBQ.Text = "BBQ Sauce";
            this.chkBBQ.UseVisualStyleBackColor = true;
            this.chkBBQ.CheckedChanged += new System.EventHandler(this.chkBBQ_CheckedChanged);
            // 
            // chkMeat
            // 
            this.chkMeat.AutoSize = true;
            this.chkMeat.Location = new System.Drawing.Point(120, 35);
            this.chkMeat.Name = "chkMeat";
            this.chkMeat.Size = new System.Drawing.Size(59, 20);
            this.chkMeat.TabIndex = 4;
            this.chkMeat.Text = "Meat";
            this.chkMeat.UseVisualStyleBackColor = true;
            this.chkMeat.CheckedChanged += new System.EventHandler(this.chkMeat_CheckedChanged);
            // 
            // chkLibnah
            // 
            this.chkLibnah.AutoSize = true;
            this.chkLibnah.Location = new System.Drawing.Point(11, 113);
            this.chkLibnah.Name = "chkLibnah";
            this.chkLibnah.Size = new System.Drawing.Size(69, 20);
            this.chkLibnah.TabIndex = 3;
            this.chkLibnah.Text = "Libnah";
            this.chkLibnah.UseVisualStyleBackColor = true;
            this.chkLibnah.CheckedChanged += new System.EventHandler(this.chkLibnah_CheckedChanged);
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(11, 87);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(77, 20);
            this.chkChicken.TabIndex = 2;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            this.chkChicken.CheckedChanged += new System.EventHandler(this.chkChicken_CheckedChanged);
            // 
            // chkHotDogs
            // 
            this.chkHotDogs.AutoSize = true;
            this.chkHotDogs.Location = new System.Drawing.Point(11, 61);
            this.chkHotDogs.Name = "chkHotDogs";
            this.chkHotDogs.Size = new System.Drawing.Size(86, 20);
            this.chkHotDogs.TabIndex = 1;
            this.chkHotDogs.Text = "Hot Dogs";
            this.chkHotDogs.UseVisualStyleBackColor = true;
            this.chkHotDogs.CheckedChanged += new System.EventHandler(this.chkHotDogs_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(11, 35);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(109, 20);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // gbPlaceOfEating
            // 
            this.gbPlaceOfEating.BackColor = System.Drawing.Color.Teal;
            this.gbPlaceOfEating.Controls.Add(this.rbOutSide);
            this.gbPlaceOfEating.Controls.Add(this.rbInside);
            this.gbPlaceOfEating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPlaceOfEating.Location = new System.Drawing.Point(504, 346);
            this.gbPlaceOfEating.Name = "gbPlaceOfEating";
            this.gbPlaceOfEating.Size = new System.Drawing.Size(229, 152);
            this.gbPlaceOfEating.TabIndex = 3;
            this.gbPlaceOfEating.TabStop = false;
            this.gbPlaceOfEating.Text = "Place Of Eating";
            this.gbPlaceOfEating.Enter += new System.EventHandler(this.gbPlaceOfEating_Enter);
            // 
            // rbOutSide
            // 
            this.rbOutSide.AutoSize = true;
            this.rbOutSide.Location = new System.Drawing.Point(120, 46);
            this.rbOutSide.Name = "rbOutSide";
            this.rbOutSide.Size = new System.Drawing.Size(96, 20);
            this.rbOutSide.TabIndex = 1;
            this.rbOutSide.TabStop = true;
            this.rbOutSide.Text = "Take Away";
            this.rbOutSide.UseVisualStyleBackColor = true;
            this.rbOutSide.CheckedChanged += new System.EventHandler(this.rbOutSide_CheckedChanged);
            // 
            // rbInside
            // 
            this.rbInside.AutoSize = true;
            this.rbInside.Location = new System.Drawing.Point(11, 46);
            this.rbInside.Name = "rbInside";
            this.rbInside.Size = new System.Drawing.Size(106, 20);
            this.rbInside.TabIndex = 0;
            this.rbInside.TabStop = true;
            this.rbInside.Text = "In Restaurant";
            this.rbInside.UseVisualStyleBackColor = true;
            this.rbInside.CheckedChanged += new System.EventHandler(this.rbInside_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Teal;
            this.gbOrderSummary.Controls.Add(this.label1);
            this.gbOrderSummary.Controls.Add(this.lblSumSummary);
            this.gbOrderSummary.Controls.Add(this.lblPlaceSummary);
            this.gbOrderSummary.Controls.Add(this.lblToppingsSummary);
            this.gbOrderSummary.Controls.Add(this.lblCrustTypeSummary);
            this.gbOrderSummary.Controls.Add(this.lblSizeSummary);
            this.gbOrderSummary.Controls.Add(this.lblSum);
            this.gbOrderSummary.Controls.Add(this.lblPlace);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrderSummary.Location = new System.Drawing.Point(928, 238);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(329, 246);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            this.gbOrderSummary.Enter += new System.EventHandler(this.gbOrderSummary_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(48, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "$";
            // 
            // lblSumSummary
            // 
            this.lblSumSummary.AutoSize = true;
            this.lblSumSummary.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumSummary.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSumSummary.Location = new System.Drawing.Point(75, 197);
            this.lblSumSummary.Name = "lblSumSummary";
            this.lblSumSummary.Size = new System.Drawing.Size(27, 28);
            this.lblSumSummary.TabIndex = 9;
            this.lblSumSummary.Text = "5";
            // 
            // lblPlaceSummary
            // 
            this.lblPlaceSummary.AutoSize = true;
            this.lblPlaceSummary.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceSummary.ForeColor = System.Drawing.Color.White;
            this.lblPlaceSummary.Location = new System.Drawing.Point(148, 173);
            this.lblPlaceSummary.Name = "lblPlaceSummary";
            this.lblPlaceSummary.Size = new System.Drawing.Size(0, 15);
            this.lblPlaceSummary.TabIndex = 8;
            // 
            // lblToppingsSummary
            // 
            this.lblToppingsSummary.AutoSize = true;
            this.lblToppingsSummary.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsSummary.ForeColor = System.Drawing.Color.White;
            this.lblToppingsSummary.Location = new System.Drawing.Point(103, 80);
            this.lblToppingsSummary.Name = "lblToppingsSummary";
            this.lblToppingsSummary.Size = new System.Drawing.Size(0, 15);
            this.lblToppingsSummary.TabIndex = 7;
            // 
            // lblCrustTypeSummary
            // 
            this.lblCrustTypeSummary.AutoSize = true;
            this.lblCrustTypeSummary.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustTypeSummary.ForeColor = System.Drawing.Color.White;
            this.lblCrustTypeSummary.Location = new System.Drawing.Point(108, 55);
            this.lblCrustTypeSummary.Name = "lblCrustTypeSummary";
            this.lblCrustTypeSummary.Size = new System.Drawing.Size(0, 15);
            this.lblCrustTypeSummary.TabIndex = 6;
            // 
            // lblSizeSummary
            // 
            this.lblSizeSummary.AutoSize = true;
            this.lblSizeSummary.Font = new System.Drawing.Font("NSimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSizeSummary.ForeColor = System.Drawing.Color.White;
            this.lblSizeSummary.Location = new System.Drawing.Point(52, 23);
            this.lblSizeSummary.Name = "lblSizeSummary";
            this.lblSizeSummary.Size = new System.Drawing.Size(0, 15);
            this.lblSizeSummary.TabIndex = 5;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(4, 197);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(48, 20);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Sum:";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(6, 167);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(131, 20);
            this.lblPlace.TabIndex = 3;
            this.lblPlace.Text = "Place Of Eating:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(6, 80);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(82, 20);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Toppings:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(6, 50);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(96, 20);
            this.lblCrustType.TabIndex = 1;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(6, 21);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(52, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size: ";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.Teal;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.ForeColor = System.Drawing.Color.White;
            this.btnOrderPizza.Location = new System.Drawing.Point(938, 528);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(138, 59);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetOrder
            // 
            this.btnResetOrder.BackColor = System.Drawing.Color.Teal;
            this.btnResetOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetOrder.ForeColor = System.Drawing.Color.White;
            this.btnResetOrder.Location = new System.Drawing.Point(1110, 528);
            this.btnResetOrder.Name = "btnResetOrder";
            this.btnResetOrder.Size = new System.Drawing.Size(138, 59);
            this.btnResetOrder.TabIndex = 6;
            this.btnResetOrder.Text = "Reset Order";
            this.btnResetOrder.UseVisualStyleBackColor = false;
            this.btnResetOrder.Click += new System.EventHandler(this.btnResetOrder_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.Teal;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(766, 528);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(138, 59);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // PizzaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 635);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnResetOrder);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbPlaceOfEating);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.DoubleBuffered = true;
            this.Name = "PizzaMenu";
            this.Text = "PizzaMenu";
            this.Load += new System.EventHandler(this.PizzaMenu_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbPlaceOfEating.ResumeLayout(false);
            this.gbPlaceOfEating.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.GroupBox gbPlaceOfEating;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetOrder;
        private System.Windows.Forms.RadioButton rbLargePizza;
        private System.Windows.Forms.RadioButton rbMediumPizza;
        private System.Windows.Forms.RadioButton rbSmallPizza;
        private System.Windows.Forms.RadioButton rbThick;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbOutSide;
        private System.Windows.Forms.RadioButton rbInside;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblSizeSummary;
        private System.Windows.Forms.Label lblPlaceSummary;
        private System.Windows.Forms.Label lblToppingsSummary;
        private System.Windows.Forms.Label lblCrustTypeSummary;
        private System.Windows.Forms.Label lblSumSummary;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkPapperoni;
        private System.Windows.Forms.CheckBox chkBBQ;
        private System.Windows.Forms.CheckBox chkMeat;
        private System.Windows.Forms.CheckBox chkLibnah;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkHotDogs;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBack;
    }
}