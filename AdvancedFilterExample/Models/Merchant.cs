namespace AdvancedFilterExample.Models
{
    public class MerchantUpdateModel : MerchantBase
    {

        public string name { get; set; }
    }
    public class MerchantBase
    {
        public string code { get; set; }
    }
}
