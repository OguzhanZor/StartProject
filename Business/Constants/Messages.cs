using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
        public static string CategoryLimitExceded="Kategori limiti aşıldıgı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="kullanıcı oluşturuldu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="pasword yanlış";
        public static string SuccessfulLogin="login işlemi başarılı";
        public static string UserAlreadyExists="kullanıcı mevcut";
        public static string AccessTokenCreated="baglantı tokenı olusturuldu";
    }
}
