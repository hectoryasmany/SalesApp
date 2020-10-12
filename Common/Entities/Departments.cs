using DevExpress.Persistent.Base;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Common.Entities
{
    [DefaultClassOptions, ImageName("BO_Employee")]
    public class Departments : INotifyPropertyChanged
    {
        private int id;
        [Browsable(false)]
        public int Id
        {
            get => id;
            protected set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }
        private string name;
        [MaxLength(50)]
        [Required]
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        private List<City> cities;
        [ForeignKey("Id")]
        public virtual List<City> Cities
        {
            get => cities;
            set
            {
                if (cities != value)
                {
                    cities = value;
                    OnPropertyChanged();
                }
            }
        }
        [DisplayName("Cities Number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        //private Country country;
        //public virtual Country Country
        //{
        //    get { return country; }
        //    set
        //    {
        //        if (country != value)
        //        {
        //            country = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}


        [Browsable(false)]
        [NotMapped]
        [JsonIgnore]
        public int IdCountry { get; set; }




        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
