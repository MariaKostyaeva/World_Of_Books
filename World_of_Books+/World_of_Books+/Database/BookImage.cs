//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace World_of_Books_.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookImage
    {
        public int IdImage { get; set; }
        public int IdBook { get; set; }
        public string ImageSource { get; set; }
        public string Image
        {
            get
            {
                if (ImageSource == null || ImageSource == "")
                {
                    ImageSource = "/Resources/no_photo.jpg";
                }
                return ImageSource;
            }
        }
    
        public virtual Book Book { get; set; }
    }
}
