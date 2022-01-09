using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Cbus.Gladsheimr.UserControls;

namespace Cbus.Gladsheimr.Gui
{
    public partial class MainForm
    {
        private static UserControl? GetUserControl(string name)
        {
            var location = new Point(3, 19);
            var tabIndex = 1;

            return name switch
            {
                "tsmiAccessoryNodeDataEvent" => new AccessoryNodeDataEventControl
                {
                    Location = location,
                    Name = "AccessoryNodeDataEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryNodeDataResponse" => new AccessoryNodeDataResponseControl
                {
                    Location = location,
                    Name = "AccessoryNodeDataResponseControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOff" => new AccessoryOffControl
                {
                    Location = location,
                    Name = "AccessoryOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOff1" => new AccessoryOff1Control
                {
                    Location = location,
                    Name = "AccessoryOff1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOff2" => new AccessoryOff2Control
                {
                    Location = location,
                    Name = "AccessoryOff2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOff3" => new AccessoryOff3Control
                {
                    Location = location,
                    Name = "AccessoryOff3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOffResponseEvent" => new AccessoryOffResponseEventControl
                {
                    Location = location,
                    Name = "AccessoryOffResponseEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOffResponseEvent1" => new AccessoryOffResponseEvent1Control
                {
                    Location = location,
                    Name = "AccessoryOffResponseEvent1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOffResponseEvent2" => new AccessoryOffResponseEvent2Control
                {
                    Location = location,
                    Name = "AccessoryOffResponseEvent2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOffResponseEvent3" => new AccessoryOffResponseEvent3Control
                {
                    Location = location,
                    Name = "AccessoryOffResponseEvent3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOn" => new AccessoryOnControl
                {
                    Location = location,
                    Name = "AccessoryOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOn1" => new AccessoryOn1Control
                {
                    Location = location,
                    Name = "AccessoryOn1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOn2" => new AccessoryOn2Control
                {
                    Location = location,
                    Name = "AccessoryOn2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOn3" => new AccessoryOn3Control
                {
                    Location = location,
                    Name = "AccessoryOn3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOnResponseEvent" => new AccessoryOnResponseEventControl
                {
                    Location = location,
                    Name = "AccessoryOnResponseEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOnResponseEvent1" => new AccessoryOnResponseEvent1Control
                {
                    Location = location,
                    Name = "AccessoryOnResponseEvent1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOnResponseEvent2" => new AccessoryOnResponseEvent2Control
                {
                    Location = location,
                    Name = "AccessoryOnResponseEvent2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOnResponseEvent3" => new AccessoryOnResponseEvent3Control
                {
                    Location = location,
                    Name = "AccessoryOnResponseEvent3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryRequestEvent" => new AccessoryRequestEventControl
                {
                    Location = location,
                    Name = "AccessoryRequestEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOff" => new AccessoryShortOffControl
                {
                    Location = location,
                    Name = "AccessoryShortOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOff1" => new AccessoryShortOff1Control
                {
                    Location = location,
                    Name = "AccessoryShortOff1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOff2" => new AccessoryShortOff2Control
                {
                    Location = location,
                    Name = "AccessoryShortOff2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOff3" => new AccessoryShortOff3Control
                {
                    Location = location,
                    Name = "AccessoryShortOff3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOn" => new AccessoryShortOnControl
                {
                    Location = location,
                    Name = "AccessoryShortOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOn1" => new AccessoryShortOn1Control
                {
                    Location = location,
                    Name = "AccessoryShortOn1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOn2" => new AccessoryShortOn2Control
                {
                    Location = location,
                    Name = "AccessoryShortOn2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOn3" => new AccessoryShortOn3Control
                {
                    Location = location,
                    Name = "AccessoryShortOn3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortRequestEvent" => new AccessoryShortRequestEventControl
                {
                    Location = location,
                    Name = "AccessoryShortRequestEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOff" => new AccessoryShortResponseOffControl
                {
                    Location = location,
                    Name = "AccessoryShortResponseOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOff1" => new AccessoryShortResponseOff1Control
                {
                    Location = location,
                    Name = "AccessoryShortResponseOff1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOff2" => new AccessoryShortResponseOff2Control
                {
                    Location = location,
                    Name = "AccessoryShortResponseOff2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOff3" => new AccessoryShortResponseOff3Control
                {
                    Location = location,
                    Name = "AccessoryShortResponseOff3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOn" => new AccessoryShortResponseOnControl
                {
                    Location = location,
                    Name = "AccessoryShortResponseOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOn1" => new AccessoryShortResponseOn1Control
                {
                    Location = location,
                    Name = "AccessoryShortResponseOn1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOn2" => new AccessoryShortResponseOn2Control
                {
                    Location = location,
                    Name = "AccessoryShortResponseOn2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOn3" => new AccessoryShortResponseOn3Control
                {
                    Location = location,
                    Name = "AccessoryShortResponseOn3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAllocateLocoToActivity" => new AllocateLocoToActivityControl
                {
                    Location = location,
                    Name = "AllocateLocoToActivityControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiClearAllEventsFromANode" => new ClearAllEventsFromANodeControl
                {
                    Location = location,
                    Name = "ClearAllEventsFromANodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiCommandStationErrorReport" => new CommandStationErrorReportControl
                {
                    Location = location,
                    Name = "CommandStationErrorReportControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiCommandStationStatusReport" => new CommandStationStatusReportControl
                {
                    Location = location,
                    Name = "CommandStationStatusReportControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiConsistEngine" => new ConsistEngineControl
                {
                    Location = location,
                    Name = "ConsistEngineControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiDebugWithOneDataByte" => new DebugWithOneDataByteControl
                {
                    Location = location,
                    Name = "DebugWithOneDataByteControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiDeviceDataEventShortMode" => new DeviceDataEventShortModeControl
                {
                    Location = location,
                    Name = "DeviceDataEventShortModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiDeviceDataResponseShortMode" => new DeviceDataResponseShortModeControl
                {
                    Location = location,
                    Name = "DeviceDataResponseShortModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiEngineReport" => new EngineReportControl
                {
                    Location = location,
                    Name = "EngineReportControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiErrorMessagesFromNodesDuringConfiguration" => new ErrorMessagesFromNodesDuringConfigurationControl
                {
                    Location = location,
                    Name = "ErrorMessagesFromNodesDuringConfigurationControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiEventSpaceLeftReplyFromNode" => new EventSpaceLeftReplyFromNodeControl
                {
                    Location = location,
                    Name = "EventSpaceLeftReplyFromNodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith1DataByte" => new ExtendedOpcodeWith1DataByteControl
                {
                    Location = location,
                    Name = "ExtendedOpcodeWith1DataByteControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith2DataBytes" => new ExtendedOpcodeWith2DataBytesControl
                {
                    Location = location,
                    Name = "ExtendedOpcodeWith2DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith3DataBytes" => new ExtendedOpcodeWith3DataBytesControl
                {
                    Location = location,
                    Name = "ExtendedOpcodeWith3DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith4DataBytes" => new ExtendedOpcodeWith4DataBytesControl
                {
                    Location = location,
                    Name = "ExtendedOpcodeWith4DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith5DataBytes" => new ExtendedOpcodeWith5DataBytesControl
                {
                    Location = location,
                    Name = "ExtendedOpcodeWith5DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith6DataBytes" => new ExtendedOpcodeWith6DataBytesControl
                {
                    Location = location,
                    Name = "ExtendedOpcodeWith6DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWithNoDataBytes" => new ExtendedOpcodeWithNoDataBytesControl
                {
                    Location = location,
                    Name = "ExtendedOpcodeWithNoDataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiFastClock" => new FastClockControl
                {
                    Location = location,
                    Name = "FastClockControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiForceASelfEnumerationCycleForUseWithCan" => new ForceASelfEnumerationCycleForUseWithCanControl
                {
                    Location = location,
                    Name = "ForceASelfEnumerationCycleForUseWithCanControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiGetEngineSession" => new GetEngineSessionControl
                {
                    Location = location,
                    Name = "GetEngineSessionControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiNodeNumberAcknowledge" => new NodeNumberAcknowledgeControl
                {
                    Location = location,
                    Name = "NodeNumberAcknowledgeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiNodeNumberRelease" => new NodeNumberReleaseControl
                {
                    Location = location,
                    Name = "NodeNumberReleaseControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiNumberOfEventsStoredInNode" => new NumberOfEventsStoredInNodeControl
                {
                    Location = location,
                    Name = "NumberOfEventsStoredInNodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiPutNodeIntoBootloadMode" => new PutNodeIntoBootloadModeControl
                {
                    Location = location,
                    Name = "PutNodeIntoBootloadModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiQueryConsist" => new QueryConsistControl
                {
                    Location = location,
                    Name = "QueryConsistControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiQueryEngine" => new QueryEngineControl
                {
                    Location = location,
                    Name = "QueryEngineControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReadBackAllStoredEventsInANode" => new ReadBackAllStoredEventsInANodeControl
                {
                    Location = location,
                    Name = "ReadBackAllStoredEventsInANodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReadCv" => new ReadCvControl
                {
                    Location = location,
                    Name = "ReadCvControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReadEventVariableInLearnMode" => new ReadEventVariableInLearnModeControl
                {
                    Location = location,
                    Name = "ReadEventVariableInLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReadNumberOfEventsAvailableInANode" => new ReadNumberOfEventsAvailableInANodeControl
                {
                    Location = location,
                    Name = "ReadNumberOfEventsAvailableInANodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReleaseEngine" => new ReleaseEngineControl
                {
                    Location = location,
                    Name = "ReleaseEngineControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReleaseNodeFromLearnMode" => new ReleaseNodeFromLearnModeControl
                {
                    Location = location,
                    Name = "ReleaseNodeFromLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRemoveEngineFromConsist" => new RemoveEngineFromConsistControl
                {
                    Location = location,
                    Name = "RemoveEngineFromConsistControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReportCv" => new ReportCvControl
                {
                    Location = location,
                    Name = "ReportCvControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequest3ByteDccPacket" => new Request3ByteDccPacketControl
                {
                    Location = location,
                    Name = "Request3ByteDccPacketControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequest4ByteDccPacket" => new Request4ByteDccPacketControl
                {
                    Location = location,
                    Name = "Request4ByteDccPacketControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequest5ByteDccPacket" => new Request5ByteDccPacketControl
                {
                    Location = location,
                    Name = "Request5ByteDccPacketControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequest6ByteDccPacket" => new Request6ByteDccPacketControl
                {
                    Location = location,
                    Name = "Request6ByteDccPacketControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestDeviceDataShortMode" => new RequestDeviceDataShortModeControl
                {
                    Location = location,
                    Name = "RequestDeviceDataShortModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestEngineSession" => new RequestEngineSessionControl
                {
                    Location = location,
                    Name = "RequestEngineSessionControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestForReadOfAnEventVariable" => new RequestForReadOfAnEventVariableControl
                {
                    Location = location,
                    Name = "RequestForReadOfAnEventVariableControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestNodeDataEvent" => new RequestNodeDataEventControl
                {
                    Location = location,
                    Name = "RequestNodeDataEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestNodeNumber" => new RequestNodeNumberControl
                {
                    Location = location,
                    Name = "RequestNodeNumberControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestReadOfANodeParameterByIndex" => new RequestReadOfANodeParameterByIndexControl
                {
                    Location = location,
                    Name = "RequestReadOfANodeParameterByIndexControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestReadOfANodeVariable" => new RequestReadOfANodeVariableControl
                {
                    Location = location,
                    Name = "RequestReadOfANodeVariableControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestReadOfStoredEventsByEventIndex" => new RequestReadOfStoredEventsByEventIndexControl
                {
                    Location = location,
                    Name = "RequestReadOfStoredEventsByEventIndexControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestToReadNumberOfStoredEvents" => new RequestToReadNumberOfStoredEventsControl
                {
                    Location = location,
                    Name = "RequestToReadNumberOfStoredEventsControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToARequestForAnEvValueInANodeInLearnMode" => new ResponseToARequestForAnEvValueInANodeInLearnModeControl
                {
                    Location = location,
                    Name = "ResponseToARequestForAnEvValueInANodeInLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToARequestForANodeVariableValue" => new ResponseToARequestForANodeVariableValueControl
                {
                    Location = location,
                    Name = "ResponseToARequestForANodeVariableValueControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToQueryNode" => new ResponseToQueryNodeControl
                {
                    Location = location,
                    Name = "ResponseToQueryNodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestForIndividualNodeParameter" => new ResponseToRequestForIndividualNodeParameterControl
                {
                    Location = location,
                    Name = "ResponseToRequestForIndividualNodeParameterControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestForNodeNameString" => new ResponseToRequestForNodeNameStringControl
                {
                    Location = location,
                    Name = "ResponseToRequestForNodeNameStringControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestForNodeParameters" => new ResponseToRequestForNodeParametersControl
                {
                    Location = location,
                    Name = "ResponseToRequestForNodeParametersControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestForReadOfEvValue" => new ResponseToRequestForReadOfEvValueControl
                {
                    Location = location,
                    Name = "ResponseToRequestForReadOfEvValueControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestToReadNodeEvents" => new ResponseToRequestToReadNodeEventsControl
                {
                    Location = location,
                    Name = "ResponseToRequestToReadNodeEventsControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiServiceModeStatus" => new ServiceModeStatusControl
                {
                    Location = location,
                    Name = "ServiceModeStatusControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSessionKeepAlive" => new SessionKeepAliveControl
                {
                    Location = location,
                    Name = "SessionKeepAliveControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetACan_idInExistingFlimNode" => new SetACan_idInExistingFlimNodeControl
                {
                    Location = location,
                    Name = "SetACan_idInExistingFlimNodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetANodeVariable" => new SetANodeVariableControl
                {
                    Location = location,
                    Name = "SetANodeVariableControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetCabSessionMode" => new SetCabSessionModeControl
                {
                    Location = location,
                    Name = "SetCabSessionModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineFlags" => new SetEngineFlagsControl
                {
                    Location = location,
                    Name = "SetEngineFlagsControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineFunctionOff" => new SetEngineFunctionOffControl
                {
                    Location = location,
                    Name = "SetEngineFunctionOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineFunctionOn" => new SetEngineFunctionOnControl
                {
                    Location = location,
                    Name = "SetEngineFunctionOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineFunctions" => new SetEngineFunctionsControl
                {
                    Location = location,
                    Name = "SetEngineFunctionsControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineSpeedAndDirection" => new SetEngineSpeedAndDirectionControl
                {
                    Location = location,
                    Name = "SetEngineSpeedAndDirectionControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetNodeIntoLearnMode" => new SetNodeIntoLearnModeControl
                {
                    Location = location,
                    Name = "SetNodeIntoLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetNodeNumber" => new SetNodeNumberControl
                {
                    Location = location,
                    Name = "SetNodeNumberControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiTeachAnEventInLearnMode" => new TeachAnEventInLearnModeControl
                {
                    Location = location,
                    Name = "TeachAnEventInLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiTeachAnEventInLearnModeUsingEventIndexing" => new TeachAnEventInLearnModeUsingEventIndexingControl
                {
                    Location = location,
                    Name = "TeachAnEventInLearnModeUsingEventIndexingControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiUnlearnAnEventInLearnMode" => new UnlearnAnEventInLearnModeControl
                {
                    Location = location,
                    Name = "UnlearnAnEventInLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteAcknowledge" => new WriteAcknowledgeControl
                {
                    Location = location,
                    Name = "WriteAcknowledgeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteCvBitInOpsMode" => new WriteCvBitInOpsModeControl
                {
                    Location = location,
                    Name = "WriteCvBitInOpsModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteCvByteInOpsMode" => new WriteCvByteInOpsModeControl
                {
                    Location = location,
                    Name = "WriteCvByteInOpsModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteCvByteInOpsModeByAddress" => new WriteCvByteInOpsModeByAddressControl
                {
                    Location = location,
                    Name = "WriteCvByteInOpsModeByAddressControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteCvInServiceMode" => new WriteCvInServiceModeControl
                {
                    Location = location,
                    Name = "WriteCvInServiceModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                _ => null
            };
        }

        private static bool IsOpCodeWithNoData(string name)
        {
            var opCodes = new[]
            {
                "tsmiAcknowledgement",
                "tsmiBusHalt",
                "tsmiBusOn",
                "tsmiEmergencyStop",
                "tsmiNack",
                "tsmiQueryNodeNumber",
                "tsmiQueryNodeResponse",
                "tsmiRequestCommandStationStatus",
                "tsmiRequestEmergencyStopAll",
                "tsmiRequestModuleName",
                "tsmiRequestNodeParameters",
                "tsmiRequestTrackOff",
                "tsmiRequestTrackOn",
                "tsmiSystemReset",
                "tsmiTrackOff",
                "tsmiTrackOn",
            };

            return opCodes.Contains(name);
        }
    }
}
