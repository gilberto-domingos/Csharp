namespace LogicExercises;
public class Variables
{
    //Todos os tipos de variaveis existentes no C#.
    // numéricos integrais
    public byte VByte;
    public decimal VDecimal;
    public double VDouble;

    // numéricos reais
    public float VFloat;
    public int VInt;
    public long VLong;
    public sbyte VSByte;
    public short VShort;
    public uint VUInt;
    public ulong VULong;
    public ushort VUShort;

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
    public DaysWeek VDaysWeek { get; set; }

    // struct personalizada
    public Point VPoint { get; set; }

    // nullable 
    public int? VIntNullable { get; set; }
    public bool? VBoolNullable { get; set; }
    public DateTime? VDateTimeNullable { get; set; }

    // dinâmico
    public dynamic VDynamic { get; set; }
}