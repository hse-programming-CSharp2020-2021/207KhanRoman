using System;

namespace MyLab
{
    public class VetoVector
    {
        public string Name { get; set; }
        Random rnd = new Random();

        public void IsVeto(object obj, VetoEventArgs e)
        {
            if (e.VetoBy == null && rnd.Next(1, 6) == 1)
            {
                e.VetoBy = this;
            }
        }
    }
    public class VetoCommision
    {
        public EventHandler<VetoEventArgs> OnChoice;

        public VetoEventArgs Vote(string proposal)
        {
            VetoEventArgs veto = new VetoEventArgs(proposal);
            OnChoice?.Invoke(this, veto);
            return veto;
        }
    }
    public class VetoEventArgs : EventArgs
    {
        public VetoEventArgs(string s)
        {
            Preoposal = s;
        }
        public string Preoposal { get; set; }
        public  VetoVector VetoBy { get; set; }
    }
}
