namespace LogicaExercicios.Entities;

public class Variaveis
{
    //Todos os tipos de variaveis existentes no C#.
    // numéricos integrais
    public byte VByte;
    public sbyte VSByte;
    public short VShort;
    public ushort VUShort;
    public int VInt;
    public uint VUInt;
    public long VLong;
    public ulong VULong;

    // numéricos reais
    public float VFloat;
    public double VDouble;
    public decimal VDecimal;

    // outros tipos primitivos
    public char VChar { get; set; }
    public bool VBool { get; set; }

    // texto e objeto
    public string? VString { get; set; }
    public object? VObjectInt { get; set; }
    public object? VObjectString { get; set; }
            
    

    // adicionais importantes
    public DateTime VDateTime { get; set; }
    public TimeSpan VTimeSpan { get; set; }
    public Guid Id { get; set; }

    // Enum
    public DiasSemana VDiaSemana { get; set; }

    // struct personalizada
    public Ponto VPonto { get; set; }

    // nullable 
    public int? VIntNullable { get; set; }
    public bool? VBoolNullable { get; set; }
    public DateTime? VDateTimeNullable { get; set; }

    // dinâmico
    public dynamic VDynamic { get; set; }
}
