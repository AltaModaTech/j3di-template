namespace Domain.entity;

using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;


public class IndividualDataRecord : IDataRecord
{
  // indivRecord positions:
  //  0 - Individual id (Guid)
  //  1 - Individual name (string)
  //  2 - Individual CreatedDate (DateTime)
  //  3 - Individual's contact info (ContactInfo)
  private object[] indivRecord = new object[4];

  // public IndividualDataRecord(Guid indivId, string indivName, DateTime created, ContactInfo contactInfo)
  public IndividualDataRecord(Guid indivId, string indivName, DateTime created)
  {
    indivRecord[0] = indivId;
    indivRecord[1] = indivName;
    indivRecord[2] = created;
    // indivRecord[3] = contactInfo;
  }


  #region IDataRecord impl

  public int FieldCount
  {
    get { return indivRecord.Length; }
  }


  /*
      Implements "column" access in the data row.  Since the internal database
      representation is a dictionary, the only valid columns are 0 and 1 (for
      the Key and Value portions of the dictionary item)
  */
  public object this[int i]
  {
    get
    {
      if (i < 0 || i >= FieldCount) { throw new IndexOutOfRangeException(); }

      return indivRecord[i];
    }
  }

  public object this[String id]
  {
    get
    {
      // TODO: look up by entity id
      throw new NotImplementedException();
    }
  }

  public String GetName(int i)
  {
    throw new NotImplementedException();
  }

  public String GetDataTypeName(int i)
  {
    throw new NotImplementedException();
  }

  public Type GetFieldType(int i)
  {
    throw new NotImplementedException();
  }

  public Object GetValue(int i)
  {
    throw new NotImplementedException();
  }

  public int GetValues(object[] values)
  {
    throw new NotImplementedException();
  }

  public int GetOrdinal(string name)
  {
    throw new NotImplementedException();
  }

  public bool GetBoolean(int i)
  {
    throw new NotImplementedException();
  }

  public byte GetByte(int i)
  {
    throw new NotImplementedException();
  }

  public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
  {
    throw new NotImplementedException();
  }

  public char GetChar(int i)
  {
    throw new NotImplementedException();
  }

  public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
  {
    throw new NotImplementedException();
  }

  public Guid GetGuid(int i)
  {
    throw new NotImplementedException();
  }

  public Int16 GetInt16(int i)
  {
    throw new NotImplementedException();
  }

  public Int32 GetInt32(int i)
  {
    throw new NotImplementedException();
  }

  public Int64 GetInt64(int i)
  {
    throw new NotImplementedException();
  }

  public float GetFloat(int i)
  {
    throw new NotImplementedException();
  }

  public double GetDouble(int i)
  {
    throw new NotImplementedException();
  }

  public String GetString(int i)
  {
    throw new NotImplementedException();
  }

  public Decimal GetDecimal(int i)
  {
    throw new NotImplementedException();
  }

  public DateTime GetDateTime(int i)
  {
    throw new NotImplementedException();
  }

  public IDataReader GetData(int i)
  {
    throw new NotImplementedException();
  }

  public bool IsDBNull(int i)
  {
    throw new NotImplementedException();
  }

  #endregion IDataRecord impl


  #region IDisposable impl

  public void Dispose() { /* nothing to dispose */ }

  #endregion IDisposable impl

}

