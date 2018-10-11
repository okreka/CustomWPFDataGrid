using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataGrid
{
    public class Item
    {
        public int ID { get; set; }

        public string No { get; set; }

        public string No2 { get; set; }

        public string Description { get; set; }

        public string SearchDescription { get; set; }

        public string LongDescription { get; set; }

        public string BaseUnitofMeasure { get; set; }

        public string Barcode { get; set; }

        public string ItemCategoryCode { get; set; }

        public string ItemGroupCode { get; set; }

        public string ItemCategory3 { get; set; }

        public string ItemCategory4 { get; set; }

        public string ItemCategory5 { get; set; }

        public string ItemCategory6 { get; set; }

        public string ItemCategory7 { get; set; }

        public string ItemCategory8 { get; set; }

        public string ItemCategory9 { get; set; }

        public string ItemCategory10 { get; set; }

        public string Ingredients { get; set; }

        public int? VWeight { get; set; }

        public int? ShelfLife { get; set; }

        public double? Tare { get; set; }

        public string LabelNO { get; set; }

        public bool? BOM { get; set; }

        public int WarrantyPeriodinMonths { get; set; }

        public bool? WarrantyforComponents { get; set; }

        public byte AllowInvoiceDisc { get; set; }

        public string VendorNO { get; set; }

        public double? PurchasePrice { get; set; }

        public double UnitPrice { get; set; }

        public double UnitPriceNoVAT { get; set; }

        public double VAT { get; set; }

        public DateTime LastDateTimeModified { get; set; }

        public byte Blocked { get; set; }

        public byte[] Picture { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public DateTime? LastSyncDate { get; set; }

        public  int Tag { get; set; }

        public bool Available { get; set; }

        public double? Coeficient { get; set; }

        public bool Traceable { get; set; }

        private string _status;

        public string Status {
            get
            {
                return _status;
            } 
            set
            {
                _status = value;
                Statuses = _status.Split('|').ToList();
            }
        }

        public List<string> Statuses { get; private set; }

    }

}
