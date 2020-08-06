
namespace ConstVarChainAssignment
{
    public class ChainClass
    {
        public int Id;
        public string Name;
        //chaining two constructors
        public ChainClass(int id)
        {
            this.Id = id;
        }

        public ChainClass(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
