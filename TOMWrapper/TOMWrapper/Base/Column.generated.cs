// Code generated by a template
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using TabularEditor.PropertyGridUI;
using TabularEditor.UndoFramework;
using TOM = Microsoft.AnalysisServices.Tabular;

namespace TabularEditor.TOMWrapper
{
  
    /// <summary>
	/// Base class declaration for Column
	/// </summary>
	[TypeConverter(typeof(DynamicPropertyConverter))]
	public abstract partial class Column: TabularNamedObject
			, IDetailObject
			, IHideableObject
			, IErrorMessageObject
			, ITabularTableObject
			, IDescriptionObject
			, IAnnotationObject
			, ITabularPerspectiveObject
			, ITranslatableObject
	{
	    protected internal new TOM.Column MetadataObject { get { return base.MetadataObject as TOM.Column; } internal set { base.MetadataObject = value; } }

        /// <summary>
        /// Gets or sets the DataType of the Column.
        /// </summary>
		[DisplayName("Data Type")]
		[Category("Metadata"),IntelliSense("The Data Type of this Column.")]
		public TOM.DataType DataType {
			get {
			    return MetadataObject.DataType;
			}
			set {
				var oldValue = DataType;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("DataType", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.DataType = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "DataType", oldValue, value));
				OnPropertyChanged("DataType", oldValue, value);
			}
		}
		private bool ShouldSerializeDataType() { return false; }
		public string GetAnnotation(string name) {
		    return MetadataObject.Annotations.Find(name)?.Value;
		}
		public void SetAnnotation(string name, string value, bool undoable = true) {
			if(MetadataObject.Annotations.Contains(name)) {
				MetadataObject.Annotations[name].Value = value;
			} else {
				MetadataObject.Annotations.Add(new TOM.Annotation{ Name = name, Value = value });
			}
			if (undoable) Handler.UndoManager.Add(new UndoAnnotationAction(this, name, value));
		}
		        /// <summary>
        /// Gets or sets the DataCategory of the Column.
        /// </summary>
		[DisplayName("Data Category")]
		[Category("Metadata"),IntelliSense("The Data Category of this Column.")]
		public string DataCategory {
			get {
			    return MetadataObject.DataCategory;
			}
			set {
				var oldValue = DataCategory;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("DataCategory", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.DataCategory = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "DataCategory", oldValue, value));
				OnPropertyChanged("DataCategory", oldValue, value);
			}
		}
		private bool ShouldSerializeDataCategory() { return false; }
        /// <summary>
        /// Gets or sets the Description of the Column.
        /// </summary>
		[DisplayName("Description")]
		[Category("Basic"),IntelliSense("The Description of this Column.")][Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string Description {
			get {
			    return MetadataObject.Description;
			}
			set {
				var oldValue = Description;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Description", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Description = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Description", oldValue, value));
				OnPropertyChanged("Description", oldValue, value);
			}
		}
		private bool ShouldSerializeDescription() { return false; }
        /// <summary>
        /// Gets or sets the IsHidden of the Column.
        /// </summary>
		[DisplayName("Hidden")]
		[Category("Basic"),IntelliSense("The Hidden of this Column.")]
		public bool IsHidden {
			get {
			    return MetadataObject.IsHidden;
			}
			set {
				var oldValue = IsHidden;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsHidden", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsHidden = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsHidden", oldValue, value));
				OnPropertyChanged("IsHidden", oldValue, value);
				Handler.UpdateObject(this);
			}
		}
		private bool ShouldSerializeIsHidden() { return false; }
        /// <summary>
        /// Gets or sets the State of the Column.
        /// </summary>
		[DisplayName("State")]
		[Category("Metadata"),IntelliSense("The State of this Column.")]
		public TOM.ObjectState State {
			get {
			    return MetadataObject.State;
			}
			
		}
		private bool ShouldSerializeState() { return false; }
        /// <summary>
        /// Gets or sets the IsUnique of the Column.
        /// </summary>
		[DisplayName("Unique")]
		[Category("Other"),IntelliSense("The Unique of this Column.")]
		public bool IsUnique {
			get {
			    return MetadataObject.IsUnique;
			}
			set {
				var oldValue = IsUnique;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsUnique", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsUnique = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsUnique", oldValue, value));
				OnPropertyChanged("IsUnique", oldValue, value);
			}
		}
		private bool ShouldSerializeIsUnique() { return false; }
        /// <summary>
        /// Gets or sets the IsKey of the Column.
        /// </summary>
		[DisplayName("Key")]
		[Category("Other"),IntelliSense("The Key of this Column.")]
		public bool IsKey {
			get {
			    return MetadataObject.IsKey;
			}
			set {
				var oldValue = IsKey;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsKey", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsKey = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsKey", oldValue, value));
				OnPropertyChanged("IsKey", oldValue, value);
			}
		}
		private bool ShouldSerializeIsKey() { return false; }
        /// <summary>
        /// Gets or sets the IsNullable of the Column.
        /// </summary>
		[DisplayName("Nullable")]
		[Category("Other"),IntelliSense("The Nullable of this Column.")]
		public bool IsNullable {
			get {
			    return MetadataObject.IsNullable;
			}
			set {
				var oldValue = IsNullable;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsNullable", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsNullable = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsNullable", oldValue, value));
				OnPropertyChanged("IsNullable", oldValue, value);
			}
		}
		private bool ShouldSerializeIsNullable() { return false; }
        /// <summary>
        /// Gets or sets the Alignment of the Column.
        /// </summary>
		[DisplayName("Alignment")]
		[Category("Other"),IntelliSense("The Alignment of this Column.")]
		public TOM.Alignment Alignment {
			get {
			    return MetadataObject.Alignment;
			}
			set {
				var oldValue = Alignment;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("Alignment", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.Alignment = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "Alignment", oldValue, value));
				OnPropertyChanged("Alignment", oldValue, value);
			}
		}
		private bool ShouldSerializeAlignment() { return false; }
        /// <summary>
        /// Gets or sets the TableDetailPosition of the Column.
        /// </summary>
		[DisplayName("Table Detail Position")]
		[Category("Other"),IntelliSense("The Table Detail Position of this Column.")]
		public int TableDetailPosition {
			get {
			    return MetadataObject.TableDetailPosition;
			}
			set {
				var oldValue = TableDetailPosition;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("TableDetailPosition", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.TableDetailPosition = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "TableDetailPosition", oldValue, value));
				OnPropertyChanged("TableDetailPosition", oldValue, value);
			}
		}
		private bool ShouldSerializeTableDetailPosition() { return false; }
        /// <summary>
        /// Gets or sets the IsDefaultLabel of the Column.
        /// </summary>
		[DisplayName("Default Label")]
		[Category("Other"),IntelliSense("The Default Label of this Column.")]
		public bool IsDefaultLabel {
			get {
			    return MetadataObject.IsDefaultLabel;
			}
			set {
				var oldValue = IsDefaultLabel;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsDefaultLabel", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsDefaultLabel = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsDefaultLabel", oldValue, value));
				OnPropertyChanged("IsDefaultLabel", oldValue, value);
			}
		}
		private bool ShouldSerializeIsDefaultLabel() { return false; }
        /// <summary>
        /// Gets or sets the IsDefaultImage of the Column.
        /// </summary>
		[DisplayName("Default Image")]
		[Category("Other"),IntelliSense("The Default Image of this Column.")]
		public bool IsDefaultImage {
			get {
			    return MetadataObject.IsDefaultImage;
			}
			set {
				var oldValue = IsDefaultImage;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsDefaultImage", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsDefaultImage = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsDefaultImage", oldValue, value));
				OnPropertyChanged("IsDefaultImage", oldValue, value);
			}
		}
		private bool ShouldSerializeIsDefaultImage() { return false; }
        /// <summary>
        /// Gets or sets the SummarizeBy of the Column.
        /// </summary>
		[DisplayName("Summarize By")]
		[Category("Other"),IntelliSense("The Summarize By of this Column.")]
		public TOM.AggregateFunction SummarizeBy {
			get {
			    return MetadataObject.SummarizeBy;
			}
			set {
				var oldValue = SummarizeBy;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("SummarizeBy", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.SummarizeBy = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "SummarizeBy", oldValue, value));
				OnPropertyChanged("SummarizeBy", oldValue, value);
			}
		}
		private bool ShouldSerializeSummarizeBy() { return false; }
        /// <summary>
        /// Gets or sets the Type of the Column.
        /// </summary>
		[DisplayName("Type")]
		[Category("Other"),IntelliSense("The Type of this Column.")]
		public TOM.ColumnType Type {
			get {
			    return MetadataObject.Type;
			}
			
		}
		private bool ShouldSerializeType() { return false; }
        /// <summary>
        /// Gets or sets the FormatString of the Column.
        /// </summary>
		[DisplayName("Format String")]
		[Category("Options"),IntelliSense("The Format String of this Column.")]
		public string FormatString {
			get {
			    return MetadataObject.FormatString;
			}
			set {
				var oldValue = FormatString;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("FormatString", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.FormatString = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "FormatString", oldValue, value));
				OnPropertyChanged("FormatString", oldValue, value);
			}
		}
		private bool ShouldSerializeFormatString() { return false; }
        /// <summary>
        /// Gets or sets the IsAvailableInMDX of the Column.
        /// </summary>
		[DisplayName("Available In MDX")]
		[Category("Other"),IntelliSense("The Available In MDX of this Column.")]
		public bool IsAvailableInMDX {
			get {
			    return MetadataObject.IsAvailableInMDX;
			}
			set {
				var oldValue = IsAvailableInMDX;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("IsAvailableInMDX", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.IsAvailableInMDX = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "IsAvailableInMDX", oldValue, value));
				OnPropertyChanged("IsAvailableInMDX", oldValue, value);
			}
		}
		private bool ShouldSerializeIsAvailableInMDX() { return false; }
        /// <summary>
        /// Gets or sets the KeepUniqueRows of the Column.
        /// </summary>
		[DisplayName("Keep Unique Rows")]
		[Category("Other"),IntelliSense("The Keep Unique Rows of this Column.")]
		public bool KeepUniqueRows {
			get {
			    return MetadataObject.KeepUniqueRows;
			}
			set {
				var oldValue = KeepUniqueRows;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("KeepUniqueRows", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.KeepUniqueRows = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "KeepUniqueRows", oldValue, value));
				OnPropertyChanged("KeepUniqueRows", oldValue, value);
			}
		}
		private bool ShouldSerializeKeepUniqueRows() { return false; }
        /// <summary>
        /// Gets or sets the DisplayOrdinal of the Column.
        /// </summary>
		[DisplayName("Display Ordinal")]
		[Category("Other"),IntelliSense("The Display Ordinal of this Column.")]
		public int DisplayOrdinal {
			get {
			    return MetadataObject.DisplayOrdinal;
			}
			set {
				var oldValue = DisplayOrdinal;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("DisplayOrdinal", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.DisplayOrdinal = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "DisplayOrdinal", oldValue, value));
				OnPropertyChanged("DisplayOrdinal", oldValue, value);
			}
		}
		private bool ShouldSerializeDisplayOrdinal() { return false; }
        /// <summary>
        /// Gets or sets the ErrorMessage of the Column.
        /// </summary>
		[DisplayName("Error Message")]
		[Category("Metadata"),IntelliSense("The Error Message of this Column.")]
		public string ErrorMessage {
			get {
			    return MetadataObject.ErrorMessage;
			}
			
		}
		private bool ShouldSerializeErrorMessage() { return false; }
        /// <summary>
        /// Gets or sets the SourceProviderType of the Column.
        /// </summary>
		[DisplayName("Source Provider Type")]
		[Category("Other"),IntelliSense("The Source Provider Type of this Column.")]
		public string SourceProviderType {
			get {
			    return MetadataObject.SourceProviderType;
			}
			set {
				var oldValue = SourceProviderType;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("SourceProviderType", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.SourceProviderType = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "SourceProviderType", oldValue, value));
				OnPropertyChanged("SourceProviderType", oldValue, value);
			}
		}
		private bool ShouldSerializeSourceProviderType() { return false; }
        /// <summary>
        /// Gets or sets the DisplayFolder of the Column.
        /// </summary>
		[DisplayName("Display Folder")]
		[Category("Basic"),IntelliSense("The Display Folder of this Column.")][Editor(typeof(CustomDialogEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string DisplayFolder {
			get {
			    return MetadataObject.DisplayFolder;
			}
			set {
				var oldValue = DisplayFolder;
				if (oldValue == value) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("DisplayFolder", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.DisplayFolder = value;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "DisplayFolder", oldValue, value));
				OnPropertyChanged("DisplayFolder", oldValue, value);
				Handler.UpdateFolders(Table);
			}
		}
		private bool ShouldSerializeDisplayFolder() { return false; }
        /// <summary>
        /// Collection of localized Display Folders for this Column.
        /// </summary>
        [Browsable(true),DisplayName("Display Folders"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedDisplayFolders { private set; get; }
		[Browsable(false)]
		public Table Table
		{ 
			get 
			{ 
				TabularObject t = null;
				if(MetadataObject == null || MetadataObject.Table == null) return null;
				if(!Handler.WrapperLookup.TryGetValue(MetadataObject.Table, out t)) {
				    t = Model.Tables[MetadataObject.Table.Name];
				}
				return t as Table;
			} 
		}
        /// <summary>
        /// Gets or sets the SortByColumn of the Column.
        /// </summary>
		[DisplayName("Sort By Column")]
		[Category("Options"),IntelliSense("The Sort By Column of this Column.")][TypeConverter(typeof(TableColumnConverter))]
		public Column SortByColumn {
			get {
				if (MetadataObject.SortByColumn == null) return null;
			    return Handler.WrapperLookup[MetadataObject.SortByColumn] as Column;
            }
			set {
				var oldValue = SortByColumn;
				if (oldValue?.MetadataObject == value?.MetadataObject) return;
				bool undoable = true;
				bool cancel = false;
				OnPropertyChanging("SortByColumn", value, ref undoable, ref cancel);
				if (cancel) return;
				MetadataObject.SortByColumn = value == null ? null : Table.Columns[value.MetadataObject.Name].MetadataObject;
				if(undoable) Handler.UndoManager.Add(new UndoPropertyChangedAction(this, "SortByColumn", oldValue, value));
				OnPropertyChanged("SortByColumn", oldValue, value);
			}
		}
		private bool ShouldSerializeSortByColumn() { return false; }

        /// <Summary>
		/// Collection of perspectives in which this Column is visible.
		/// </Summary>
		[Browsable(true),DisplayName("Perspectives"), Category("Translations and Perspectives")]
        public PerspectiveIndexer InPerspective { get; private set; }
        /// <summary>
        /// Collection of localized descriptions for this Column.
        /// </summary>
        [Browsable(true),DisplayName("Descriptions"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedDescriptions { private set; get; }
        /// <summary>
        /// Collection of localized names for this Column.
        /// </summary>
        [Browsable(true),DisplayName("Names"),Category("Translations and Perspectives")]
	    public TranslationIndexer TranslatedNames { private set; get; }


		/// <summary>
		/// Creates a Column object representing an existing TOM Column.
		/// </summary>
		internal Column(TOM.Column metadataObject) : base(metadataObject)
		{
			TranslatedNames = new TranslationIndexer(this, TOM.TranslatedProperty.Caption);
			TranslatedDescriptions = new TranslationIndexer(this, TOM.TranslatedProperty.Description);
			TranslatedDisplayFolders = new TranslationIndexer(this, TOM.TranslatedProperty.DisplayFolder);
			InPerspective = new PerspectiveColumnIndexer(this);
		}	

		public override bool Browsable(string propertyName) {
			switch (propertyName) {
				
				// Hides translation properties in the grid, unless the model actually contains translations:
				case "TranslatedNames":
				case "TranslatedDescriptions":
				case "TranslatedDisplayFolders":
					return Model.Cultures.Any();
				
				// Hides the perspective property in the grid, unless the model actually contains perspectives:
				case "InPerspective":
					return Model.Perspectives.Any();
				
				default:
					return base.Browsable(propertyName);
			}
		}

    }


	/// <summary>
	/// Collection class for Column. Provides convenient properties for setting a property on multiple objects at once.
	/// </summary>
	public partial class ColumnCollection: TabularObjectCollection<Column, TOM.Column, TOM.Table>
	{
		public Table Parent { get; private set; }

		public ColumnCollection(string collectionName, TOM.ColumnCollection metadataObjectCollection, Table parent) : base(collectionName, metadataObjectCollection)
		{
			Parent = parent;

			// Construct child objects (they are automatically added to the Handler's WrapperLookup dictionary):
			foreach(var obj in MetadataObjectCollection) {
				switch(obj.Type) {
				    case TOM.ColumnType.Data: new DataColumn(obj as TOM.DataColumn) { Collection = this }; break;
					case TOM.ColumnType.Calculated: new CalculatedColumn(obj as TOM.CalculatedColumn) { Collection = this }; break;
					case TOM.ColumnType.CalculatedTableColumn: new CalculatedTableColumn(obj as TOM.CalculatedTableColumn) { Collection = this }; break;
					default: break;
				}
			}
		}

		[Description("Sets the DataType property of all objects in the collection at once.")]
		public TOM.DataType DataType {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("DataType"));
				this.ToList().ForEach(item => { item.DataType = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the DataCategory property of all objects in the collection at once.")]
		public string DataCategory {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("DataCategory"));
				this.ToList().ForEach(item => { item.DataCategory = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the Description property of all objects in the collection at once.")]
		public string Description {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("Description"));
				this.ToList().ForEach(item => { item.Description = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsHidden property of all objects in the collection at once.")]
		public bool IsHidden {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsHidden"));
				this.ToList().ForEach(item => { item.IsHidden = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsUnique property of all objects in the collection at once.")]
		public bool IsUnique {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsUnique"));
				this.ToList().ForEach(item => { item.IsUnique = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsKey property of all objects in the collection at once.")]
		public bool IsKey {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsKey"));
				this.ToList().ForEach(item => { item.IsKey = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsNullable property of all objects in the collection at once.")]
		public bool IsNullable {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsNullable"));
				this.ToList().ForEach(item => { item.IsNullable = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the Alignment property of all objects in the collection at once.")]
		public TOM.Alignment Alignment {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("Alignment"));
				this.ToList().ForEach(item => { item.Alignment = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the TableDetailPosition property of all objects in the collection at once.")]
		public int TableDetailPosition {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("TableDetailPosition"));
				this.ToList().ForEach(item => { item.TableDetailPosition = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsDefaultLabel property of all objects in the collection at once.")]
		public bool IsDefaultLabel {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsDefaultLabel"));
				this.ToList().ForEach(item => { item.IsDefaultLabel = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsDefaultImage property of all objects in the collection at once.")]
		public bool IsDefaultImage {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsDefaultImage"));
				this.ToList().ForEach(item => { item.IsDefaultImage = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the SummarizeBy property of all objects in the collection at once.")]
		public TOM.AggregateFunction SummarizeBy {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("SummarizeBy"));
				this.ToList().ForEach(item => { item.SummarizeBy = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the FormatString property of all objects in the collection at once.")]
		public string FormatString {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("FormatString"));
				this.ToList().ForEach(item => { item.FormatString = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the IsAvailableInMDX property of all objects in the collection at once.")]
		public bool IsAvailableInMDX {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("IsAvailableInMDX"));
				this.ToList().ForEach(item => { item.IsAvailableInMDX = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the KeepUniqueRows property of all objects in the collection at once.")]
		public bool KeepUniqueRows {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("KeepUniqueRows"));
				this.ToList().ForEach(item => { item.KeepUniqueRows = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the DisplayOrdinal property of all objects in the collection at once.")]
		public int DisplayOrdinal {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("DisplayOrdinal"));
				this.ToList().ForEach(item => { item.DisplayOrdinal = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the SourceProviderType property of all objects in the collection at once.")]
		public string SourceProviderType {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("SourceProviderType"));
				this.ToList().ForEach(item => { item.SourceProviderType = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the DisplayFolder property of all objects in the collection at once.")]
		public string DisplayFolder {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("DisplayFolder"));
				this.ToList().ForEach(item => { item.DisplayFolder = value; });
				Handler.UndoManager.EndBatch();
			}
		}
		[Description("Sets the SortByColumn property of all objects in the collection at once.")]
		public Column SortByColumn {
			set {
				if(Handler == null) return;
				Handler.UndoManager.BeginBatch(UndoPropertyChangedAction.GetActionNameFromProperty("SortByColumn"));
				this.ToList().ForEach(item => { item.SortByColumn = value; });
				Handler.UndoManager.EndBatch();
			}
		}

		public override string ToString() {
			return string.Format("({0} {1})", Count, (Count == 1 ? "Column" : "Columns").ToLower());
		}
	}
}
