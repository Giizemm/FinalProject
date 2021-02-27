using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountCategoryError = "Bir kategoride en fazla 10 ürün bulunabilir.";
        public static string ProductNameError = "Aynı isimde ürün bulunamaz.";

        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered="Kayıtlı Kullanıcı";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola Hatası";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kayıtlı kullanıcı var";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
