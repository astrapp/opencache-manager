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
    
    
    public partial class ReduceLogsDialog {
        
        private Gtk.HBox hbox2;
        
        private Gtk.Label label12;
        
        private Gtk.Entry limitEntry;
        
        private Gtk.Label label13;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.ReduceLogsDialog
            this.Name = "ocmgtk.ReduceLogsDialog";
            this.Title = Mono.Unix.Catalog.GetString("Reduce Number of Logs...");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Internal child ocmgtk.ReduceLogsDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label12 = new Gtk.Label();
            this.label12.Name = "label12";
            this.label12.LabelProp = Mono.Unix.Catalog.GetString("Limit cache to:");
            this.hbox2.Add(this.label12);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox2[this.label12]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.limitEntry = new Gtk.Entry();
            this.limitEntry.CanFocus = true;
            this.limitEntry.Name = "limitEntry";
            this.limitEntry.Text = Mono.Unix.Catalog.GetString("10");
            this.limitEntry.IsEditable = true;
            this.limitEntry.WidthChars = 4;
            this.limitEntry.InvisibleChar = '●';
            this.hbox2.Add(this.limitEntry);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox2[this.limitEntry]));
            w3.Position = 1;
            w3.Expand = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.label13 = new Gtk.Label();
            this.label13.Name = "label13";
            this.label13.LabelProp = Mono.Unix.Catalog.GetString("logs");
            this.hbox2.Add(this.label13);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox2[this.label13]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            w1.Add(this.hbox2);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(w1[this.hbox2]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            w5.Padding = ((uint)(6));
            // Internal child ocmgtk.ReduceLogsDialog.ActionArea
            Gtk.HButtonBox w6 = this.ActionArea;
            w6.Name = "dialog1_ActionArea";
            w6.Spacing = 10;
            w6.BorderWidth = ((uint)(5));
            w6.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanDefault = true;
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-cancel";
            this.AddActionWidget(this.buttonCancel, -6);
            Gtk.ButtonBox.ButtonBoxChild w7 = ((Gtk.ButtonBox.ButtonBoxChild)(w6[this.buttonCancel]));
            w7.Expand = false;
            w7.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w8 = ((Gtk.ButtonBox.ButtonBoxChild)(w6[this.buttonOk]));
            w8.Position = 1;
            w8.Expand = false;
            w8.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 349;
            this.DefaultHeight = 123;
            this.Show();
            this.buttonCancel.Clicked += new System.EventHandler(this.OnCancelClicked);
            this.buttonOk.Clicked += new System.EventHandler(this.OnOKClicked);
        }
    }
}
