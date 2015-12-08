// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ocmgtk {
    
    
    public partial class ImportDialog {
        
        private Gtk.FileChooserWidget fileWidget;
        
        private Gtk.Expander expander1;
        
        private Gtk.VBox vbox2;
        
        private Gtk.CheckButton oldLogsCheck;
        
        private Gtk.CheckButton statusCheck;
        
        private Gtk.CheckButton gsakFieldsCheck;
        
        private Gtk.HBox hbox1;
        
        private Gtk.CheckButton addToListCheck;
        
        private Gtk.ComboBox bmCombo;
        
        private Gtk.Button addBmrkButton;
        
        private Gtk.Image image20;
        
        private Gtk.Label GtkLabel17;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.ImportDialog
            this.WidthRequest = 700;
            this.HeightRequest = 500;
            this.Name = "ocmgtk.ImportDialog";
            this.Title = Mono.Unix.Catalog.GetString("Import GPX/LOC/ZIP..");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.Resizable = false;
            this.AllowGrow = false;
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Internal child ocmgtk.ImportDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.fileWidget = new Gtk.FileChooserWidget(((Gtk.FileChooserAction)(0)));
            this.fileWidget.Name = "fileWidget";
            w1.Add(this.fileWidget);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(w1[this.fileWidget]));
            w2.Position = 0;
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.expander1 = new Gtk.Expander(null);
            this.expander1.CanFocus = true;
            this.expander1.Name = "expander1";
            this.expander1.Expanded = true;
            // Container child expander1.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.oldLogsCheck = new Gtk.CheckButton();
            this.oldLogsCheck.CanFocus = true;
            this.oldLogsCheck.Name = "oldLogsCheck";
            this.oldLogsCheck.Label = Mono.Unix.Catalog.GetString("Purge old cache logs");
            this.oldLogsCheck.DrawIndicator = true;
            this.oldLogsCheck.UseUnderline = true;
            this.vbox2.Add(this.oldLogsCheck);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.oldLogsCheck]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.statusCheck = new Gtk.CheckButton();
            this.statusCheck.CanFocus = true;
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Label = Mono.Unix.Catalog.GetString("Do not overwrite existing found status in database");
            this.statusCheck.DrawIndicator = true;
            this.statusCheck.UseUnderline = true;
            this.vbox2.Add(this.statusCheck);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.statusCheck]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.gsakFieldsCheck = new Gtk.CheckButton();
            this.gsakFieldsCheck.CanFocus = true;
            this.gsakFieldsCheck.Name = "gsakFieldsCheck";
            this.gsakFieldsCheck.Label = Mono.Unix.Catalog.GetString("Ignore GSAK/OCM extra fields in GPX file");
            this.gsakFieldsCheck.DrawIndicator = true;
            this.gsakFieldsCheck.UseUnderline = true;
            this.vbox2.Add(this.gsakFieldsCheck);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox2[this.gsakFieldsCheck]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.addToListCheck = new Gtk.CheckButton();
            this.addToListCheck.CanFocus = true;
            this.addToListCheck.Name = "addToListCheck";
            this.addToListCheck.Label = Mono.Unix.Catalog.GetString("Add to bookmark list:");
            this.addToListCheck.DrawIndicator = true;
            this.addToListCheck.UseUnderline = true;
            this.hbox1.Add(this.addToListCheck);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.addToListCheck]));
            w6.Position = 0;
            w6.Expand = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.bmCombo = Gtk.ComboBox.NewText();
            this.bmCombo.Sensitive = false;
            this.bmCombo.Name = "bmCombo";
            this.hbox1.Add(this.bmCombo);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox1[this.bmCombo]));
            w7.Position = 1;
            w7.Expand = false;
            w7.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.addBmrkButton = new Gtk.Button();
            this.addBmrkButton.CanFocus = true;
            this.addBmrkButton.Name = "addBmrkButton";
            // Container child addBmrkButton.Gtk.Container+ContainerChild
            this.image20 = new Gtk.Image();
            this.image20.Sensitive = false;
            this.image20.Name = "image20";
            this.image20.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-add", Gtk.IconSize.Menu, 16);
            this.addBmrkButton.Add(this.image20);
            this.addBmrkButton.Label = null;
            this.hbox1.Add(this.addBmrkButton);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox1[this.addBmrkButton]));
            w9.Position = 2;
            w9.Expand = false;
            w9.Fill = false;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w10.Position = 3;
            w10.Expand = false;
            w10.Fill = false;
            this.expander1.Add(this.vbox2);
            this.GtkLabel17 = new Gtk.Label();
            this.GtkLabel17.Name = "GtkLabel17";
            this.GtkLabel17.LabelProp = Mono.Unix.Catalog.GetString("Options");
            this.GtkLabel17.UseUnderline = true;
            this.expander1.LabelWidget = this.GtkLabel17;
            w1.Add(this.expander1);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(w1[this.expander1]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            w12.Padding = ((uint)(6));
            // Internal child ocmgtk.ImportDialog.ActionArea
            Gtk.HButtonBox w13 = this.ActionArea;
            w13.Name = "dialog1_ActionArea";
            w13.Spacing = 10;
            w13.BorderWidth = ((uint)(5));
            w13.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w14 = ((Gtk.ButtonBox.ButtonBoxChild)(w13[this.buttonCancel]));
            w14.Expand = false;
            w14.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-open";
            this.AddActionWidget(this.buttonOk, -3);
            Gtk.ButtonBox.ButtonBoxChild w15 = ((Gtk.ButtonBox.ButtonBoxChild)(w13[this.buttonOk]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 721;
            this.DefaultHeight = 527;
            this.Show();
            this.fileWidget.FileActivated += new System.EventHandler(this.OnFileActivated);
            this.addToListCheck.Toggled += new System.EventHandler(this.OnAddToBmrkToggle);
            this.addBmrkButton.Clicked += new System.EventHandler(this.OnAddClicked);
            this.buttonCancel.Clicked += new System.EventHandler(this.OnCancelClicked);
            this.buttonOk.Clicked += new System.EventHandler(this.OnOkClicked);
        }
    }
}
