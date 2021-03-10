using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi gecersizdir";
        public static string MaintenanceTime="Bakım zamanı";
        public static string ProductListed= "Ürünler listeleniyor";
        public static string ProductNameAlreadyExists="Bu isimde başka bir ürün var.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        internal static string CategoryLimitExceded="Kategori limiti aşıldıgı için yeni ürün eklenemiyor.";
    }
}
