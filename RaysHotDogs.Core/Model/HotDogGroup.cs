using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaysHotDogs.Core.Models
{
    public class HotDogGroup
    {
        public HotDogGroup()
        {
        }

        public int HotDogGroupId
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }

        public List<HotDog> HotDogs
        {
            get;
            set;
        }
    }
}
