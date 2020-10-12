using DevExpress.Persistent.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace Common.Entities
{
    [DefaultClassOptions, ImageName("BO_Employee")]
    public class City: INotifyPropertyChanged
    {
        private int id;
        [Browsable(false)]
        public int Id
        {
            get { return id; }
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
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        //private Departments department;
        //public virtual Departments Department
        //{
        //    get { return department; }
        //    set
        //    {
        //        if (department != value)
        //        {
        //            department = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        [Browsable(false)]
        [NotMapped]
        [JsonIgnore]
        public int IdDepartment { get; set; }




        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
