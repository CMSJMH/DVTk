// ------------------------------------------------------
// DVTk - The Healthcare Validation Toolkit (www.dvtk.org)
// Copyright ? 2009 DVTk
// ------------------------------------------------------
// This file is part of DVTk.
//
// DVTk is free software; you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License as published by the Free Software Foundation; either version 3.0
// of the License, or (at your option) any later version. 
// 
// DVTk is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even
// the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser
// General Public License for more details. 
// 
// You should have received a copy of the GNU Lesser General Public License along with this
// library; if not, see <http://www.gnu.org/licenses/>

#pragma once
#include "MBaseSession.h"

namespace Wrappers
{
    public __gc class MMediaSession
        : public MBaseSession
        , public System::IDisposable
    {
    private:
        MEDIA_SESSION_CLASS __nogc* m_pMEDIA_SESSION_CLASS;
    private protected:
        __property BASE_SESSION_CLASS __nogc* get_m_pBASE_SESSION()
        {
            return m_pMEDIA_SESSION_CLASS;
        }
    public:
        // <summary>
        // Constructor
        // </summary>
        // <remarks>
        // None
        // </remarks>
        MMediaSession(void);
    public:
        // <summary>
        // Destructor
        // </summary>
        // <remarks>
        // None
        // </remarks>
        ~MMediaSession(void);

    public:
        System::Boolean Validate(
            DvtkData::Media::DicomFile __gc* pDicomFile, 
            Wrappers::ValidationControlFlags validationControlFlags);

	 public:
        System::Boolean Validate(
            DvtkData::Media::DicomFile __gc* pDicomFile, 
			Wrappers::ValidationControlFlags validationControlFlags, System::String* fileName);


	public:
		System::Boolean GenerateDICOMDIR(
			System::String __gc* dcmFileNames[]);

    private:
        // Track whether Dispose has been called.
        // m_pMEDIA_SESSION_CLASS is treated as disposable resource.
        bool disposed;

    public:
        void Dispose();

    private:
        void Dispose(bool disposing);
    };
}
