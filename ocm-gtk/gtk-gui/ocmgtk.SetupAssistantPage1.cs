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
    
    
    public partial class SetupAssistantPage1 {
        
        private Gtk.VBox vbox2;
        
        private Gtk.Label label3;
        
        private Gtk.Button button1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.SetupAssistantPage1
            Stetic.BinContainer.Attach(this);
            this.WidthRequest = 300;
            this.HeightRequest = 0;
            this.Name = "ocmgtk.SetupAssistantPage1";
            // Container child ocmgtk.SetupAssistantPage1.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(6));
            // Container child vbox2.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Welcome to OCM! This assistant will guide you through setting up OCM for first time use. You will need to know your home coordinates from your GPS, plus some information from your preferred caching website. \n\nFor Geocaching.com and Terracaching users, you will need a premium account to use all of the features of OCM. If you don't have an account, click on the button below to sign up to Geocaching.com");
            this.label3.Wrap = true;
            this.label3.WidthChars = 60;
            this.vbox2.Add(this.label3);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.label3]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.button1 = new Gtk.Button();
            this.button1.CanFocus = true;
            this.button1.Name = "button1";
            this.button1.UseUnderline = true;
            this.button1.Label = Mono.Unix.Catalog.GetString("Sign Up for an Account...");
            this.vbox2.Add(this.button1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox2[this.button1]));
            w2.PackType = ((Gtk.PackType)(1));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Hide();
            this.button1.Clicked += new System.EventHandler(this.OnButton1Activated);
        }
    }
}
