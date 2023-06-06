using Lab6new.Models.Interface;
using Lab6new.RepresentationFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6new
{
    internal static class Extensions
    {
        public static Predicate<IModel> GetFilterFromComboBox(
           this ComboBox comboBox, Func<IModel, object> selector
           )
        {
            if (comboBox.SelectedValue == null)
                return (x) => true;
            return (x) => selector(x).ToString() == comboBox.SelectedValue.ToString();
        }
        public static Predicate<IModel> GetFilterFromBoolGroupBox(
            this GroupBox groupBox, Func<IModel, bool> selector
            )
        {

            var checkBoxes = groupBox.Controls.OfType<CheckBox>().ToArray();

            if (checkBoxes[0].Checked == checkBoxes[1].Checked)
                return (x) => checkBoxes[0].Checked && checkBoxes[1].Checked;

            return (x) => selector(x) == checkBoxes[0].Checked;
        }
        public static void SetDataToComboBox<T>(this ComboBox comboBox, List<T> data)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.DataSource = data;
            comboBox.SelectedItem = null;
        }

        public static Predicate<T1> GlueFilters<T1>(this List<Predicate<T1>> predicates)
        {
            return delegate (T1 item)
            {
                foreach (Predicate<T1> predicate in predicates)
                {
                    if (!predicate(item))
                    {
                        return false;
                    }
                }
                return true;
            };
        }
        public static IEnumerable<object[]> ToExport(this IEnumerable<IExportRepresentation> data)
        {
            foreach(var item in data)
                yield return item.GetExportData();
        }
    }
}
