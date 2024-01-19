using Syncfusion.Maui.DataForm;

namespace NumericItem_Percentage
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        private SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("dataForm");
            if (this.dataForm != null)
            {
                this.dataForm.ColumnCount = 2;
                this.dataForm.ItemsSourceProvider = new ItemSourceProvider();
                this.dataForm.RegisterEditor("Tickets", DataFormEditorType.Picker);
                this.dataForm.RegisterEditor("Venue", DataFormEditorType.Picker);
                this.dataForm.RegisterEditor("PaymentMethod", DataFormEditorType.ComboBox);
                this.dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
                this.dataForm.CommitMode = DataFormCommitMode.PropertyChanged;
                this.dataForm.ValidationMode = DataFormValidationMode.PropertyChanged;
            }
        }

        private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)

            {
                if (e.DataFormItem.FieldName == "Occupancy" && e.DataFormItem is DataFormNumericItem percentage)
                {
                    percentage.AllowNull = false;

                    // In C#, the backslash '\' is an escape character, so to include a literal backslash in a string, need to use a double backslash '\\'.
                    percentage.CustomFormat = "0\\%";
                    percentage.ShowClearButton = false;
                    percentage.Maximum = 99.0;
                    percentage.Minimum = 0.0;
                    percentage.Keyboard = Keyboard.Numeric;
                }
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.dataForm != null)
            {
                this.dataForm = null;
            }
        }
    }
}