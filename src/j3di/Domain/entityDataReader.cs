namespace Domain.entity;

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;


public class IndividualDataReader : IDataReader
{

    public IndividualDataReader(List<IndividualDataRecord> indivs)
    {
        _indivs = indivs;
        _cursor = -1;
    }

    private List<IndividualDataRecord> _indivs = null;
    private int _cursor = -1;


    #region IDataReader impl

    public int Depth
    {
        get
        {
            // No nesting involved
            return 0;
        }
    }

    public bool IsClosed
    {
        get;
        private set;
    }

    public int RecordsAffected
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public void Close() { IsClosed = true; }

    public DataTable GetSchemaTable()
    {
        throw new NotImplementedException();
    }

    public bool NextResult()
    {
        throw new NotImplementedException();
    }

    public bool Read()
    {
        bool dataAvailable = false;

        if (_cursor < _indivs.Count)
        {
            if (++_cursor < _indivs.Count)
            {
                dataAvailable = true;
            }
        }

        return dataAvailable;
    }

    #endregion IDataReader impl


    #region IDataRecord impl

    public int FieldCount
    {
        // Delegate to IndividualDataRecord
        get { return _indivs[0].FieldCount; }
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
            // Delegate to IndividualDataRecord
            IndividualDataRecord r = _indivs[_cursor];
            System.Diagnostics.Trace.Assert(null != r);
            object retval = r[i];
            System.Diagnostics.Trace.Assert(null != retval);
            return retval;
        }
    }

    public object this[String name]
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