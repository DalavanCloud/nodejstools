// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Text.Editor;

namespace TestUtilities.Mocks
{
    public class MockTextOptions : IEditorOptions
    {
        public bool ClearOptionValue<T>(EditorOptionKey<T> key)
        {
            throw new NotImplementedException();
        }

        public bool ClearOptionValue(string optionId)
        {
            throw new NotImplementedException();
        }

        public object GetOptionValue(string optionId)
        {
            if (optionId == DefaultOptions.ConvertTabsToSpacesOptionId.Name)
            {
                return true;
            }
            else if (optionId == DefaultOptions.IndentSizeOptionId.Name)
            {
                return 4;
            }

            throw new InvalidOperationException();
        }

        public T GetOptionValue<T>(EditorOptionKey<T> key)
        {
            if (key.Equals(DefaultOptions.ConvertTabsToSpacesOptionId))
            {
                return (T)(object)true;
            }
            else if (key.Equals(DefaultOptions.IndentSizeOptionId))
            {
                return (T)(object)4;
            }
            else if (key.Equals(DefaultOptions.NewLineCharacterOptionId))
            {
                return (T)(object)"\r\n";
            }
            else if (key.Equals(DefaultOptions.TabSizeOptionId))
            {
                return (T)(object)4;
            }
            throw new InvalidOperationException();
        }

        public T GetOptionValue<T>(string optionId)
        {
            return (T)GetOptionValue(optionId);
        }

        public IEditorOptions GlobalOptions
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsOptionDefined<T>(EditorOptionKey<T> key, bool localScopeOnly)
        {
            throw new NotImplementedException();
        }

        public bool IsOptionDefined(string optionId, bool localScopeOnly)
        {
            throw new NotImplementedException();
        }

        public event EventHandler<EditorOptionChangedEventArgs> OptionChanged
        {
            add { }
            remove { }
        }

        public IEditorOptions Parent
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void SetOptionValue<T>(EditorOptionKey<T> key, T value)
        {
            throw new NotImplementedException();
        }

        public void SetOptionValue(string optionId, object value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EditorOptionDefinition> SupportedOptions
        {
            get { throw new NotImplementedException(); }
        }
    }
}

