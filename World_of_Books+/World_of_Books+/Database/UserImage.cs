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
    
    public partial class UserImage
    {
        public int IdUserImage { get; set; }
        public int IdUser { get; set; }
        public byte[] ImageSource { get; set; }
    
        public virtual User User { get; set; }
    }
}