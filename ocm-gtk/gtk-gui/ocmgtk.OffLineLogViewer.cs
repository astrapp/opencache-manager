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
    
    
    public partial class OffLineLogViewer {
        
        private Gtk.VPaned vpaned1;
        
        private Gtk.VBox vbox3;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Image image11;
        
        private Gtk.Label fnFieldNotesLabel;
        
        private Gtk.HSeparator hseparator1;
        
        private Gtk.HBox hbox2;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TreeView logView;
        
        private Gtk.VButtonBox vbuttonbox1;
        
        private Gtk.Button viewCacheButton;
        
        private Gtk.Button deleteButton;
        
        private Gtk.Button delAllButton;
        
        private Gtk.Notebook fieldNotesDescPane;
        
        private Gtk.VBox logPane;
        
        private Gtk.HBox hbox5;
        
        private Gtk.Label label1;
        
        private Gtk.ComboBox logChoice;
        
        private Gtk.HBox hbox4;
        
        private Gtk.CheckButton firstToFindCheck;
        
        private Gtk.Button saveButton;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TextView logEntry;
        
        private Gtk.Label logPage;
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Label wptCombo;
        
        private Gtk.ComboBox waypointCombo;
        
        private ocmgtk.MapWidget mapView;
        
        private Gtk.Label label7;
        
        private ocmgtk.HTMLWidget cacheDesc;
        
        private Gtk.Label label5;
        
        private ocmgtk.HTMLWidget cacheLog;
        
        private Gtk.Label label8;
        
        private ocmgtk.NotesWidget cacheNotes;
        
        private Gtk.Label notesLabel;
        
        private Gtk.Button closeButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget ocmgtk.OffLineLogViewer
            this.WidthRequest = 600;
            this.HeightRequest = 400;
            this.Name = "ocmgtk.OffLineLogViewer";
            this.Title = Mono.Unix.Catalog.GetString("View Field Notes...");
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Modal = true;
            this.BorderWidth = ((uint)(6));
            this.AllowShrink = true;
            this.Gravity = ((Gdk.Gravity)(5));
            this.SkipPagerHint = true;
            this.SkipTaskbarHint = true;
            // Internal child ocmgtk.OffLineLogViewer.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.Spacing = 6;
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vpaned1 = new Gtk.VPaned();
            this.vpaned1.CanFocus = true;
            this.vpaned1.Name = "vpaned1";
            this.vpaned1.Position = 250;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.image11 = new Gtk.Image();
            this.image11.Name = "image11";
            this.image11.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-info", Gtk.IconSize.LargeToolbar, 24);
            this.hbox1.Add(this.image11);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.image11]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.fnFieldNotesLabel = new Gtk.Label();
            this.fnFieldNotesLabel.Name = "fnFieldNotesLabel";
            this.fnFieldNotesLabel.LabelProp = Mono.Unix.Catalog.GetString("Please wait...");
            this.hbox1.Add(this.fnFieldNotesLabel);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.fnFieldNotesLabel]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            this.vbox3.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hseparator1 = new Gtk.HSeparator();
            this.hseparator1.Name = "hseparator1";
            this.vbox3.Add(this.hseparator1);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.hseparator1]));
            w5.Position = 1;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.logView = new Gtk.TreeView();
            this.logView.CanFocus = true;
            this.logView.Name = "logView";
            this.logView.EnableSearch = false;
            this.scrolledwindow1.Add(this.logView);
            this.hbox2.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox2[this.scrolledwindow1]));
            w7.Position = 0;
            // Container child hbox2.Gtk.Box+BoxChild
            this.vbuttonbox1 = new Gtk.VButtonBox();
            this.vbuttonbox1.Name = "vbuttonbox1";
            this.vbuttonbox1.Spacing = 6;
            this.vbuttonbox1.LayoutStyle = ((Gtk.ButtonBoxStyle)(3));
            // Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.viewCacheButton = new Gtk.Button();
            this.viewCacheButton.Sensitive = false;
            this.viewCacheButton.CanFocus = true;
            this.viewCacheButton.Name = "viewCacheButton";
            this.viewCacheButton.UseUnderline = true;
            this.viewCacheButton.Label = Mono.Unix.Catalog.GetString("View Cache");
            this.vbuttonbox1.Add(this.viewCacheButton);
            Gtk.ButtonBox.ButtonBoxChild w8 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.viewCacheButton]));
            w8.Expand = false;
            w8.Fill = false;
            // Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.deleteButton = new Gtk.Button();
            this.deleteButton.Sensitive = false;
            this.deleteButton.CanFocus = true;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseStock = true;
            this.deleteButton.UseUnderline = true;
            this.deleteButton.Label = "gtk-delete";
            this.vbuttonbox1.Add(this.deleteButton);
            Gtk.ButtonBox.ButtonBoxChild w9 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.deleteButton]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            // Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
            this.delAllButton = new Gtk.Button();
            this.delAllButton.CanFocus = true;
            this.delAllButton.Name = "delAllButton";
            this.delAllButton.UseUnderline = true;
            this.delAllButton.Label = Mono.Unix.Catalog.GetString("Delete All");
            this.vbuttonbox1.Add(this.delAllButton);
            Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.delAllButton]));
            w10.Position = 2;
            w10.Expand = false;
            w10.Fill = false;
            this.hbox2.Add(this.vbuttonbox1);
            Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(this.hbox2[this.vbuttonbox1]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            w11.Padding = ((uint)(6));
            this.vbox3.Add(this.hbox2);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
            w12.Position = 2;
            this.vpaned1.Add(this.vbox3);
            Gtk.Paned.PanedChild w13 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.vbox3]));
            w13.Resize = false;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.fieldNotesDescPane = new Gtk.Notebook();
            this.fieldNotesDescPane.Sensitive = false;
            this.fieldNotesDescPane.CanFocus = true;
            this.fieldNotesDescPane.Name = "fieldNotesDescPane";
            this.fieldNotesDescPane.CurrentPage = 0;
            this.fieldNotesDescPane.TabPos = ((Gtk.PositionType)(0));
            // Container child fieldNotesDescPane.Gtk.Notebook+NotebookChild
            this.logPane = new Gtk.VBox();
            this.logPane.Name = "logPane";
            this.logPane.Spacing = 6;
            this.logPane.BorderWidth = ((uint)(6));
            // Container child logPane.Gtk.Box+BoxChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Log Type:");
            this.hbox5.Add(this.label1);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.hbox5[this.label1]));
            w14.Position = 0;
            w14.Expand = false;
            w14.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.logChoice = Gtk.ComboBox.NewText();
            this.logChoice.AppendText(Mono.Unix.Catalog.GetString("Found it"));
            this.logChoice.AppendText(Mono.Unix.Catalog.GetString("Didn't Find it"));
            this.logChoice.AppendText(Mono.Unix.Catalog.GetString("Write Note"));
            this.logChoice.AppendText(Mono.Unix.Catalog.GetString("Needs Maintenance"));
            this.logChoice.Name = "logChoice";
            this.logChoice.Active = 0;
            this.hbox5.Add(this.logChoice);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.hbox5[this.logChoice]));
            w15.Position = 1;
            w15.Expand = false;
            w15.Fill = false;
            this.logPane.Add(this.hbox5);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.logPane[this.hbox5]));
            w16.Position = 0;
            w16.Expand = false;
            w16.Fill = false;
            // Container child logPane.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.firstToFindCheck = new Gtk.CheckButton();
            this.firstToFindCheck.CanFocus = true;
            this.firstToFindCheck.Name = "firstToFindCheck";
            this.firstToFindCheck.Label = Mono.Unix.Catalog.GetString("First To Find");
            this.firstToFindCheck.DrawIndicator = true;
            this.firstToFindCheck.UseUnderline = true;
            this.hbox4.Add(this.firstToFindCheck);
            Gtk.Box.BoxChild w17 = ((Gtk.Box.BoxChild)(this.hbox4[this.firstToFindCheck]));
            w17.Position = 0;
            // Container child hbox4.Gtk.Box+BoxChild
            this.saveButton = new Gtk.Button();
            this.saveButton.CanFocus = true;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseStock = true;
            this.saveButton.UseUnderline = true;
            this.saveButton.Label = "gtk-save";
            this.hbox4.Add(this.saveButton);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox4[this.saveButton]));
            w18.Position = 1;
            w18.Expand = false;
            w18.Fill = false;
            this.logPane.Add(this.hbox4);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.logPane[this.hbox4]));
            w19.Position = 1;
            w19.Expand = false;
            w19.Fill = false;
            // Container child logPane.Gtk.Box+BoxChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.logEntry = new Gtk.TextView();
            this.logEntry.CanFocus = true;
            this.logEntry.Name = "logEntry";
            this.logEntry.WrapMode = ((Gtk.WrapMode)(2));
            this.GtkScrolledWindow.Add(this.logEntry);
            this.logPane.Add(this.GtkScrolledWindow);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.logPane[this.GtkScrolledWindow]));
            w21.Position = 2;
            this.fieldNotesDescPane.Add(this.logPane);
            // Notebook tab
            this.logPage = new Gtk.Label();
            this.logPage.Name = "logPage";
            this.logPage.LabelProp = Mono.Unix.Catalog.GetString("Field Log");
            this.fieldNotesDescPane.SetTabLabel(this.logPane, this.logPage);
            this.logPage.ShowAll();
            // Container child fieldNotesDescPane.Gtk.Notebook+NotebookChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.wptCombo = new Gtk.Label();
            this.wptCombo.Name = "wptCombo";
            this.wptCombo.LabelProp = Mono.Unix.Catalog.GetString("Waypoint:");
            this.hbox3.Add(this.wptCombo);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox3[this.wptCombo]));
            w23.Position = 0;
            w23.Expand = false;
            w23.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.waypointCombo = Gtk.ComboBox.NewText();
            this.waypointCombo.Name = "waypointCombo";
            this.hbox3.Add(this.waypointCombo);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.hbox3[this.waypointCombo]));
            w24.Position = 1;
            w24.Expand = false;
            w24.Fill = false;
            this.vbox2.Add(this.hbox3);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
            w25.Position = 0;
            w25.Expand = false;
            w25.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.mapView = new ocmgtk.MapWidget();
            this.mapView.Events = ((Gdk.EventMask)(256));
            this.mapView.Name = "mapView";
            this.mapView.ShowNearby = false;
            this.mapView.ShowAllChildren = false;
            this.vbox2.Add(this.mapView);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.vbox2[this.mapView]));
            w26.Position = 1;
            this.fieldNotesDescPane.Add(this.vbox2);
            Gtk.Notebook.NotebookChild w27 = ((Gtk.Notebook.NotebookChild)(this.fieldNotesDescPane[this.vbox2]));
            w27.Position = 1;
            // Notebook tab
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Map");
            this.fieldNotesDescPane.SetTabLabel(this.vbox2, this.label7);
            this.label7.ShowAll();
            // Container child fieldNotesDescPane.Gtk.Notebook+NotebookChild
            this.cacheDesc = new ocmgtk.HTMLWidget();
            this.cacheDesc.Events = ((Gdk.EventMask)(256));
            this.cacheDesc.Name = "cacheDesc";
            this.fieldNotesDescPane.Add(this.cacheDesc);
            Gtk.Notebook.NotebookChild w28 = ((Gtk.Notebook.NotebookChild)(this.fieldNotesDescPane[this.cacheDesc]));
            w28.Position = 2;
            // Notebook tab
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Cache Description");
            this.fieldNotesDescPane.SetTabLabel(this.cacheDesc, this.label5);
            this.label5.ShowAll();
            // Container child fieldNotesDescPane.Gtk.Notebook+NotebookChild
            this.cacheLog = new ocmgtk.HTMLWidget();
            this.cacheLog.Events = ((Gdk.EventMask)(256));
            this.cacheLog.Name = "cacheLog";
            this.fieldNotesDescPane.Add(this.cacheLog);
            Gtk.Notebook.NotebookChild w29 = ((Gtk.Notebook.NotebookChild)(this.fieldNotesDescPane[this.cacheLog]));
            w29.Position = 3;
            // Notebook tab
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("Cache Logs");
            this.fieldNotesDescPane.SetTabLabel(this.cacheLog, this.label8);
            this.label8.ShowAll();
            // Container child fieldNotesDescPane.Gtk.Notebook+NotebookChild
            this.cacheNotes = new ocmgtk.NotesWidget();
            this.cacheNotes.Events = ((Gdk.EventMask)(256));
            this.cacheNotes.Name = "cacheNotes";
            this.fieldNotesDescPane.Add(this.cacheNotes);
            Gtk.Notebook.NotebookChild w30 = ((Gtk.Notebook.NotebookChild)(this.fieldNotesDescPane[this.cacheNotes]));
            w30.Position = 4;
            // Notebook tab
            this.notesLabel = new Gtk.Label();
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.LabelProp = Mono.Unix.Catalog.GetString("Notes");
            this.fieldNotesDescPane.SetTabLabel(this.cacheNotes, this.notesLabel);
            this.notesLabel.ShowAll();
            this.vpaned1.Add(this.fieldNotesDescPane);
            w1.Add(this.vpaned1);
            Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(w1[this.vpaned1]));
            w32.Position = 0;
            // Internal child ocmgtk.OffLineLogViewer.ActionArea
            Gtk.HButtonBox w33 = this.ActionArea;
            w33.Name = "dialog1_ActionArea";
            w33.Spacing = 10;
            w33.BorderWidth = ((uint)(5));
            w33.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.closeButton = new Gtk.Button();
            this.closeButton.CanDefault = true;
            this.closeButton.CanFocus = true;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseStock = true;
            this.closeButton.UseUnderline = true;
            this.closeButton.Label = "gtk-close";
            this.AddActionWidget(this.closeButton, -7);
            Gtk.ButtonBox.ButtonBoxChild w34 = ((Gtk.ButtonBox.ButtonBoxChild)(w33[this.closeButton]));
            w34.Expand = false;
            w34.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 839;
            this.DefaultHeight = 566;
            this.closeButton.HasDefault = true;
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnCloseClick);
            this.viewCacheButton.Clicked += new System.EventHandler(this.OnViewCache);
            this.deleteButton.Clicked += new System.EventHandler(this.OnDeleteClick);
            this.delAllButton.Clicked += new System.EventHandler(this.OnDeleteAllClick);
            this.logChoice.Changed += new System.EventHandler(this.OnLogTypeChange);
            this.firstToFindCheck.Toggled += new System.EventHandler(this.OnFTFCheck);
            this.saveButton.Clicked += new System.EventHandler(this.OnSaveClick);
            this.closeButton.Clicked += new System.EventHandler(this.OnCloseClick);
        }
    }
}
