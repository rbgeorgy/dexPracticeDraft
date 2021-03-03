namespace ValueTypeAndReferenceTypeClassLibrary
{
    public class SomethingNeedToBeCloned : IMyClonable
    {
        public bool PropBool { get; set; }
        public short PropShort { get; set; }
        public int PropInt { get; set; }
        public double PropDouble { get; set; }
        public EnumForOurClass PropEnum { get; set; }
        public Pair<char> PropStruct { get; set; }


        public object Clone()
        {
            return new SomethingNeedToBeCloned {
                PropBool = this.PropBool, 
                PropShort = this.PropShort, 
                PropInt = this.PropInt, 
                PropDouble = this.PropDouble, 
                PropEnum = this.PropEnum, 
                PropStruct =this.PropStruct
            };
        }
    }
}