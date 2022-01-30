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
            var location = new Point(3, 27);
            var tabIndex = 1;

            return name switch
            {
                "tsmiAccessoryNodeDataEvent" => new AccessoryNodeDataEventControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryNodeDataEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryNodeDataResponse" => new AccessoryNodeDataResponseControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryNodeDataResponseControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOff" => new AccessoryOffControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOff1" => new AccessoryOff1Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOff1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOff2" => new AccessoryOff2Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOff2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOff3" => new AccessoryOff3Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOff3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOffResponseEvent" => new AccessoryOffResponseEventControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOffResponseEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOffResponseEvent1" => new AccessoryOffResponseEvent1Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOffResponseEvent1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOffResponseEvent2" => new AccessoryOffResponseEvent2Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOffResponseEvent2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOffResponseEvent3" => new AccessoryOffResponseEvent3Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOffResponseEvent3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOn" => new AccessoryOnControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOn1" => new AccessoryOn1Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOn1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOn2" => new AccessoryOn2Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOn2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOn3" => new AccessoryOn3Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOn3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOnResponseEvent" => new AccessoryOnResponseEventControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOnResponseEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOnResponseEvent1" => new AccessoryOnResponseEvent1Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOnResponseEvent1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOnResponseEvent2" => new AccessoryOnResponseEvent2Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOnResponseEvent2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryOnResponseEvent3" => new AccessoryOnResponseEvent3Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryOnResponseEvent3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryRequestEvent" => new AccessoryRequestEventControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryRequestEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOff" => new AccessoryShortOffControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOff1" => new AccessoryShortOff1Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortOff1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOff2" => new AccessoryShortOff2Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortOff2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOff3" => new AccessoryShortOff3Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortOff3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOn" => new AccessoryShortOnControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOn1" => new AccessoryShortOn1Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortOn1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOn2" => new AccessoryShortOn2Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortOn2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortOn3" => new AccessoryShortOn3Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortOn3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortRequestEvent" => new AccessoryShortRequestEventControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortRequestEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOff" => new AccessoryShortResponseOffControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortResponseOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOff1" => new AccessoryShortResponseOff1Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortResponseOff1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOff2" => new AccessoryShortResponseOff2Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortResponseOff2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOff3" => new AccessoryShortResponseOff3Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortResponseOff3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOn" => new AccessoryShortResponseOnControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortResponseOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOn1" => new AccessoryShortResponseOn1Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortResponseOn1Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOn2" => new AccessoryShortResponseOn2Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortResponseOn2Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAccessoryShortResponseOn3" => new AccessoryShortResponseOn3Control
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AccessoryShortResponseOn3Control",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiAllocateLocoToActivity" => new AllocateLocoToActivityControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "AllocateLocoToActivityControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiBusHalt" => new BusHaltControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "BusHaltControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiBusOn" => new BusOnControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "BusOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiClearAllEventsFromANode" => new ClearAllEventsFromANodeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ClearAllEventsFromANodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiCommandStationErrorReport" => new CommandStationErrorReportControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "CommandStationErrorReportControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiCommandStationStatusReport" => new CommandStationStatusReportControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "CommandStationStatusReportControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiConsistEngine" => new ConsistEngineControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ConsistEngineControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiDebugWithOneDataByte" => new DebugWithOneDataByteControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "DebugWithOneDataByteControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiDeviceDataEventShortMode" => new DeviceDataEventShortModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "DeviceDataEventShortModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiDeviceDataResponseShortMode" => new DeviceDataResponseShortModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "DeviceDataResponseShortModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiEmergencyStop" => new EmergencyStopControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "EmergencyStopControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiEngineReport" => new EngineReportControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "EngineReportControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiErrorMessagesFromNodesDuringConfiguration" => new ErrorMessagesFromNodesDuringConfigurationControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ErrorMessagesFromNodesDuringConfigurationControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiEventSpaceLeftReplyFromNode" => new EventSpaceLeftReplyFromNodeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "EventSpaceLeftReplyFromNodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith1DataByte" => new ExtendedOpcodeWith1DataByteControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ExtendedOpcodeWith1DataByteControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith2DataBytes" => new ExtendedOpcodeWith2DataBytesControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ExtendedOpcodeWith2DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith3DataBytes" => new ExtendedOpcodeWith3DataBytesControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ExtendedOpcodeWith3DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith4DataBytes" => new ExtendedOpcodeWith4DataBytesControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ExtendedOpcodeWith4DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith5DataBytes" => new ExtendedOpcodeWith5DataBytesControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ExtendedOpcodeWith5DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWith6DataBytes" => new ExtendedOpcodeWith6DataBytesControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ExtendedOpcodeWith6DataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiExtendedOpcodeWithNoDataBytes" => new ExtendedOpcodeWithNoDataBytesControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ExtendedOpcodeWithNoDataBytesControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiFastClock" => new FastClockControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "FastClockControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiForceASelfEnumerationCycleForUseWithCan" => new ForceASelfEnumerationCycleForUseWithCanControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ForceASelfEnumerationCycleForUseWithCanControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiGetEngineSession" => new GetEngineSessionControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "GetEngineSessionControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiNodeNumberAcknowledge" => new NodeNumberAcknowledgeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "NodeNumberAcknowledgeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiNodeNumberRelease" => new NodeNumberReleaseControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "NodeNumberReleaseControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiNumberOfEventsStoredInNode" => new NumberOfEventsStoredInNodeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "NumberOfEventsStoredInNodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiPutNodeIntoBootloadMode" => new PutNodeIntoBootloadModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "PutNodeIntoBootloadModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiQueryConsist" => new QueryConsistControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "QueryConsistControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiQueryEngine" => new QueryEngineControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "QueryEngineControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiQueryNodeNumber" => new QueryNodeNumberControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "QueryNodeNumberControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReadBackAllStoredEventsInANode" => new ReadBackAllStoredEventsInANodeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ReadBackAllStoredEventsInANodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReadCv" => new ReadCvControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ReadCvControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReadEventVariableInLearnMode" => new ReadEventVariableInLearnModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ReadEventVariableInLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReadNumberOfEventsAvailableInANode" => new ReadNumberOfEventsAvailableInANodeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ReadNumberOfEventsAvailableInANodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReleaseEngine" => new ReleaseEngineControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ReleaseEngineControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReleaseNodeFromLearnMode" => new ReleaseNodeFromLearnModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ReleaseNodeFromLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRemoveEngineFromConsist" => new RemoveEngineFromConsistControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RemoveEngineFromConsistControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiReportCv" => new ReportCvControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ReportCvControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequest3ByteDccPacket" => new Request3ByteDccPacketControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "Request3ByteDccPacketControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequest4ByteDccPacket" => new Request4ByteDccPacketControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "Request4ByteDccPacketControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequest5ByteDccPacket" => new Request5ByteDccPacketControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "Request5ByteDccPacketControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequest6ByteDccPacket" => new Request6ByteDccPacketControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "Request6ByteDccPacketControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestCommandStationStatus" => new RequestCommandStationStatusControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestCommandStationStatusControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestDeviceDataShortMode" => new RequestDeviceDataShortModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestDeviceDataShortModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestEmergencyStopAll" => new RequestEmergencyStopAllControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestEmergencyStopAllControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestEngineSession" => new RequestEngineSessionControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestEngineSessionControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestForReadOfAnEventVariable" => new RequestForReadOfAnEventVariableControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestForReadOfAnEventVariableControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestModuleName" => new RequestModuleNameControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestModuleNameControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestNodeDataEvent" => new RequestNodeDataEventControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestNodeDataEventControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestNodeNumber" => new RequestNodeNumberControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestNodeNumberControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestNodeParameters" => new RequestNodeParametersControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestNodeParametersControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestReadOfANodeParameterByIndex" => new RequestReadOfANodeParameterByIndexControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestReadOfANodeParameterByIndexControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestReadOfANodeVariable" => new RequestReadOfANodeVariableControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestReadOfANodeVariableControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestReadOfStoredEventsByEventIndex" => new RequestReadOfStoredEventsByEventIndexControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestReadOfStoredEventsByEventIndexControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestToReadNumberOfStoredEvents" => new RequestToReadNumberOfStoredEventsControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestToReadNumberOfStoredEventsControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestTrackOff" => new RequestTrackOffControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestTrackOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiRequestTrackOn" => new RequestTrackOnControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "RequestTrackOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToARequestForAnEvValueInANodeInLearnMode" => new ResponseToARequestForAnEvValueInANodeInLearnModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ResponseToARequestForAnEvValueInANodeInLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToARequestForANodeVariableValue" => new ResponseToARequestForANodeVariableValueControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ResponseToARequestForANodeVariableValueControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToQueryNode" => new ResponseToQueryNodeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ResponseToQueryNodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestForIndividualNodeParameter" => new ResponseToRequestForIndividualNodeParameterControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ResponseToRequestForIndividualNodeParameterControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestForNodeNameString" => new ResponseToRequestForNodeNameStringControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ResponseToRequestForNodeNameStringControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestForNodeParameters" => new ResponseToRequestForNodeParametersControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ResponseToRequestForNodeParametersControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestForReadOfEvValue" => new ResponseToRequestForReadOfEvValueControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ResponseToRequestForReadOfEvValueControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiResponseToRequestToReadNodeEvents" => new ResponseToRequestToReadNodeEventsControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ResponseToRequestToReadNodeEventsControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiServiceModeStatus" => new ServiceModeStatusControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "ServiceModeStatusControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSessionKeepAlive" => new SessionKeepAliveControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SessionKeepAliveControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetACan_idInExistingFlimNode" => new SetACan_idInExistingFlimNodeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetACan_idInExistingFlimNodeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetANodeVariable" => new SetANodeVariableControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetANodeVariableControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetCabSessionMode" => new SetCabSessionModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetCabSessionModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineFlags" => new SetEngineFlagsControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetEngineFlagsControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineFunctionOff" => new SetEngineFunctionOffControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetEngineFunctionOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineFunctionOn" => new SetEngineFunctionOnControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetEngineFunctionOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineFunctions" => new SetEngineFunctionsControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetEngineFunctionsControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetEngineSpeedAndDirection" => new SetEngineSpeedAndDirectionControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetEngineSpeedAndDirectionControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetNodeIntoLearnMode" => new SetNodeIntoLearnModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetNodeIntoLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSetNodeNumber" => new SetNodeNumberControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SetNodeNumberControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiSystemReset" => new SystemResetControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "SystemResetControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiTeachAnEventInLearnMode" => new TeachAnEventInLearnModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "TeachAnEventInLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiTeachAnEventInLearnModeUsingEventIndexing" => new TeachAnEventInLearnModeUsingEventIndexingControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "TeachAnEventInLearnModeUsingEventIndexingControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiTrackOff" => new TrackOffControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "TrackOffControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiTrackOn" => new TrackOnControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "TrackOnControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiUnlearnAnEventInLearnMode" => new UnlearnAnEventInLearnModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "UnlearnAnEventInLearnModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteAcknowledge" => new WriteAcknowledgeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "WriteAcknowledgeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteCvBitInOpsMode" => new WriteCvBitInOpsModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "WriteCvBitInOpsModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteCvByteInOpsMode" => new WriteCvByteInOpsModeControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "WriteCvByteInOpsModeControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteCvByteInOpsModeByAddress" => new WriteCvByteInOpsModeByAddressControl
                {
                    AutoSize = true,
                    Location = location,
                    Name = "WriteCvByteInOpsModeByAddressControl",
                    TabIndex = tabIndex,
                    TabStop = true,
                },
                "tsmiWriteCvInServiceMode" => new WriteCvInServiceModeControl
                {
                    AutoSize = true,
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
                "tsmiNack",
                "tsmiQueryNodeResponse",
            };

            return opCodes.Contains(name);
        }
    }
}
