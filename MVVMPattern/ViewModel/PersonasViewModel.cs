using MVVMPattern.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMPattern.ViewModel
{
    public class PersonasViewModel : ViewModelBase
    {
        ObservableCollection<Persona> personas;
        Persona personaActual;
        RelayCommand addPersonCommand,saveCommand;

        public PersonasViewModel()
        {
            this.Personas = new ObservableCollection<Persona>();
            this.addPersonCommand = new RelayCommand(p => this.AddPerson(), p => true);
            this.saveCommand = new RelayCommand(p => this.Save(), p => this.sePuedeSave());
            AddPerson();
        }
        
        #region Propiedades
        public ObservableCollection<Persona> Personas
        {
            get
            {
                return personas;
            }
            set
            {
                personas = value;
                OnPropertyChanged("Personas");
            }
        }

        public Persona PersonaActual
        {
            get
            {
                return personaActual;
            }
            set
            {
                personaActual = value;
                OnPropertyChanged("PersonaActual");
            }
        }

        public RelayCommand AddPersonCommand
        {
            get
            {
                return addPersonCommand;
            }
        }

        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand;
            }
        }
        #endregion

        #region Métodos
        private void Save()
        {
            if (!personas.Contains(personaActual))
                Personas.Add(personaActual);
        }

        private bool sePuedeSave()
        {
            return personaActual != null &&
                !string.IsNullOrEmpty(personaActual.Name) &&
                !string.IsNullOrEmpty(personaActual.FirstName);
        }

        private void AddPerson()
        {
            this.PersonaActual = new Persona();
        }
        #endregion
    }
}
