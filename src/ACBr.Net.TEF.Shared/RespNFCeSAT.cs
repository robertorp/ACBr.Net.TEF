// ***********************************************************************
// Assembly         : ACBr.Net.TEFD
// Author           : RFTD
// Created          : 02-18-2015
//
// Last Modified By : RFTD
// Last Modified On : 02-18-2015
// ***********************************************************************
// <copyright file="RespNFCeSAT.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using ACBr.Net.Core.Generics;

namespace ACBr.Net.TEF
{
    [Serializable]
    public sealed class RespNFCeSAT : GenericClone<RespNFCeSAT>
    {
        #region Constructors

        internal RespNFCeSAT()
        {
            Clear();
        }

        #endregion Constructors

        #region Properties

        public string CodCredenciadora { get; internal set; }

        public string CNPJCredenciadora { get; internal set; }

        public string Bandeira { get; internal set; }

        public string Autorizacao { get; internal set; }

        public string DonoCartao { get; internal set; }

        public string DataExpiracao { get; internal set; }

        public string UltimosQuatroDigitos { get; internal set; }

        #endregion Properties

        #region Methods

        public void Clear()
        {
            CodCredenciadora = string.Empty;
            CNPJCredenciadora = string.Empty;
            Bandeira = string.Empty;
            Autorizacao = string.Empty;
            DonoCartao = string.Empty;
            DataExpiracao = string.Empty;
            UltimosQuatroDigitos = string.Empty;
        }

        #endregion Methods
    }
}