﻿/*
    Intersect Game Engine (Editor)
    Copyright (C) 2015  JC Snider, Joe Bridges
    
    Website: http://ascensiongamedev.com
    Contact Email: admin@ascensiongamedev.com 

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/
using System;
using System.Windows.Forms;
using Intersect_Editor.Classes;
using Intersect_Library;
using Intersect_Library.GameObjects.Events;
using Intersect_Library.Localization;

namespace Intersect_Editor.Forms.Editors.Event_Commands
{
    public partial class EventCommand_StartCommonEvent : UserControl
    {
        private EventCommand _myCommand;
        private readonly FrmEvent _eventEditor;
        public EventCommand_StartCommonEvent(EventCommand refCommand, FrmEvent editor)
        {
            InitializeComponent();
            _myCommand = refCommand;
            _eventEditor = editor;
            InitLocalization();
            cmbEvent.Items.Clear();
            cmbEvent.Items.AddRange(Database.GetGameObjectList(GameObject.CommonEvent));
            cmbEvent.SelectedIndex = Database.GameObjectListIndex(GameObject.CommonEvent,refCommand.Ints[0]);
        }

        private void InitLocalization()
        {
            grpCommonEvent.Text = Strings.Get("eventstartcommonevent", "title");
            lblCommonEvent.Text = Strings.Get("eventstartcommonevent", "label");
            btnSave.Text = Strings.Get("eventstartcommonevent", "okay");
            btnCancel.Text = Strings.Get("eventstartcommonevent", "cancel");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _myCommand.Ints[0] = Database.GameObjectIdFromList(GameObject.CommonEvent,cmbEvent.SelectedIndex);
            _eventEditor.FinishCommandEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _eventEditor.CancelCommandEdit();
        }
    }
}