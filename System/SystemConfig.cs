namespace YamahaReceiverLib.System;

public class SystemConfig : YamahaAV
{
    public enum setdimmer
    {
        auto = -1,
        manual = 0
    }

    /// <summary>
    ///     For connecting Bluetooth (Sink) device. This API is available only when “bluetooth_tx_setting” is true
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    public async Task<string> connectBluetoothDevice(string address) => await HttpGet($"/v1/system/connectBluetoothDevice?address={address}");

    /// <summary>
    ///     For disconnecting Bluetooth (Sink) device. This API is available only when “bluetooth_tx_setting” is true
    /// </summary>
    /// <returns></returns>
    public async Task<string> disconnectBluetoothDevice() => await HttpGet("/v1/system/disconnectBluetoothDevice");

    /// <summary>
    ///     For retrieving Bluetooth (Sink) device list. This API is available only when “bluetooth_tx_setting” is true
    /// </summary>
    /// <returns></returns>
    public async Task<string> getBluetoothDeviceList() => await HttpGet("/v1/system/getBluetoothDeviceList");

    /// <summary>
    ///     For setting Bluetooth Standby
    /// </summary>
    /// <returns></returns>
    public async Task<string> getBluetoothInfo() => await HttpGet("/v1/system/getBluetoothInfo");

    /// <summary>
    ///     For retrieving basic information of a Device
    /// </summary>
    /// <returns></returns>
    public async Task<string> getDeviceInfo() => await HttpGet("/v1/system/getDeviceInfo");

    /// <summary>
    ///     For retrieving feature information equipped with a Device
    /// </summary>
    /// <returns></returns>
    public async Task<string> getFeatures() => await HttpGet("/v1/system/getFeatures");

    /// <summary>
    ///     For retrieving setup/information of overall system function
    /// </summary>
    /// <returns></returns>
    public async Task<string> getFuncStatus() => await HttpGet("/v1/system/getFuncStatus");

    /// <summary>
    ///     For retrieving Location information
    /// </summary>
    /// <returns></returns>
    public async Task<string> getLocationInfo() => await HttpGet("/v1/system/getLocationInfo");

    /// <summary>
    ///     For retrieving setup of MAC Address Filter
    /// </summary>
    /// <returns></returns>
    public async Task<string> getMacAddressFilter() => await HttpGet("/v1/system/getMacAddressFilter");

    /// <summary>
    ///     For retrieving text information of Zone, Input, Sound program. If they can be renamed, can retrieve text
    ///     information renamed.
    /// </summary>
    /// <returns></returns>
    public async Task<string> getNameText() => await HttpGet("/v1/system/getNameText");

    /// <summary>
    ///     For retrieving setup of Network Standby
    /// </summary>
    /// <returns></returns>
    public async Task<string> getNetworkStandby() => await HttpGet("/v1/system/getNetworkStandby");

    /// <summary>
    ///     For retrieving network related setup / information
    /// </summary>
    /// <returns></returns>
    public async Task<string> getNetworkStatus() => await HttpGet("/v1/system/getNetworkStatus");

    /// <summary>
    ///     For sending specific remote IR code. A Device is operated same as remote IR code reception. But continuous IR code
    ///     cannot be used in this command.Refer to each Device’s IR code list for details
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public async Task<string> sendIrCode(string code) => await HttpGet($"/v1/system/sendIrCode?code={code}");

    /// <summary>
    ///     For setting AirPlay PIN. This is valid only when “airplay” exists in “func_list” found in /system/getFuncStatus
    /// </summary>
    /// <param name="pin"></param>
    /// <returns></returns>
    public async Task<string> setAirPlayPin(string pin)
    {
        var data = $"{{\"pin\":\"{pin}\"}}";
        return await HttpSet("/v1/system/setAirPlayPin", data);
    }

    /// <summary>
    ///     For setting Auto Power Standby status. Actual operations/reactions of enabling Auto Power Standby depend on each
    ///     Device
    /// </summary>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setAutoPowerStandby(bool boolvalue) => await HttpGet($"/v1/system/setAutoPowerStandby?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting Bluetooth Standby
    /// </summary>
    /// <returns></returns>
    public async Task<string> setBluetoothStandby() => await HttpGet("/v1/system/setBluetoothStandby");

    /// <summary>
    ///     For setting Bluetooth transmission
    /// </summary>
    /// <returns></returns>
    public async Task<string> setBluetoothTxSetting() => await HttpGet("/v1/system/setBluetoothTxSetting");

    /// <summary>
    ///     For setting FL/LED Dimmer
    /// </summary>
    /// <param name="enable"></param>
    /// <returns></returns>
    public async Task<string> SetDimmer(setdimmer enable) => await HttpGet($"/v1/system/setDimmer?enable={(int)enable}");

    /// <summary>
    ///     For setting HDMI OUT 1 terminal output status
    /// </summary>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setHdmiOut1(bool boolvalue) => await HttpGet($"/v1/system/setHdmiOut1?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting HDMI OUT 2 terminal output status
    /// </summary>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setHdmiOut2(bool boolvalue) => await HttpGet($"/v1/system/setHdmiOut2?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting IP. This API only set IP as maintain same network connection status (Wired/Wireless Lan/Wireless
    ///     Direct/Extend). If no parameter is specified, current parameter is used.If set parameter is incomplete, it is
    ///     possible not to provide network avalability.
    /// </summary>
    /// <param name="BoolDHCP"></param>
    /// <param name="ip_address"></param>
    /// <param name="dns_server_1"></param>
    /// <param name="dns_server_2"></param>
    /// <param name="subnet_mask"></param>
    /// <param name="default_gateway"></param>
    /// <returns></returns>
    public async Task<string> setIpSettings(string BoolDHCP, string ip_address, string dns_server_1,
        string dns_server_2,
        string subnet_mask = "255.255.255.0", string default_gateway = "192.168.1.1")
    {
        var data =
            $"{{\"dhcp\":{BoolDHCP.ToLower()},\"ip_address\":\"{ip_address}\",\"subnet_mask\":\"{subnet_mask}\",\"default_gateway\":\"{default_gateway}\",\"dns_server_1\":\"{dns_server_1}\",\"dns_server_2\":\"{dns_server_2}\"}}";
        return await HttpSet("/v1/system/setIpSettings", data);
    }

    /// <summary>
    ///     For setting remote control IR sensor
    /// </summary>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setIrSensor(bool boolvalue) => await HttpGet($"/v1/system/setIrSensor?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting MAC Address Filter
    /// </summary>
    /// <returns></returns>
    public async Task<string> setMacAddressFilter() => await HttpSet("/v1/system/setMacAddressFilter");

    /// <summary>
    ///     For setting text information related to each ID of Zone, Input
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public async Task<string> setNameText(string name) => await HttpSet($"/v1/system/setNameText?enable={name}");

    /// <summary>
    ///     For setting Network Name (Friendly Name)
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public async Task<string> setNetworkName(string name)
    {
        var data = $"{{\"name\":\"{name}\"}}";
        return await HttpSet("/v1/system/setNetworkName", data);
    }

    /// <summary>
    ///     For setting Network Standby
    /// </summary>
    /// <returns></returns>
    public async Task<string> setNetworkStandby() => await HttpGet("/v1/system/setNetworkStandby");

    /// <summary>
    ///     For setting Speaker A status
    /// </summary>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setSpeakerA(bool boolvalue) => await HttpGet($"/v1/system/setSpeakerA?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting Speaker B status
    /// </summary>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setSpeakerB(bool boolvalue) => await HttpGet($"/v1/system/setSpeakerB?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For setting Wired Network. Network connection is switched to wired by using this API. If no parameter is specified,
    ///     current parameter is used.If set parameter is incomplete, it is possible not to provide network avalability
    /// </summary>
    /// <param name="BoolDHCP"></param>
    /// <param name="ip_address"></param>
    /// <param name="dns_server_1"></param>
    /// <param name="dns_server_2"></param>
    /// <param name="subnet_mask"></param>
    /// <param name="default_gateway"></param>
    /// <returns></returns>
    public async Task<string> setWiredLan(string BoolDHCP, string ip_address, string dns_server_1, string dns_server_2,
        string subnet_mask = "255.255.255.0", string default_gateway = "192.168.1.1")
    {
        var data =
            $"{{\"dhcp\":\"{BoolDHCP.ToLower()}\",\"ip_address\":\"{ip_address}\",\"subnet_mask\":\"{subnet_mask}\",\"default_gateway\":\"{default_gateway}\",\"dns_server_1\":\"{dns_server_1}\",\"dns_server_2\":\"{dns_server_2}\"}}";
        return await HttpSet("/v1/system/setWiredLan", data);
    }

    /// <summary>
    ///     For setting Wireless Network (Wireless Direct). Network connection is switched to wireless (Wireless Direct) by
    ///     using this API.If no parameter is specified, current parameter is used.If set parameter is incomplete, it is
    ///     possible not to provide network avalability
    /// </summary>
    /// <param name="type"></param>
    /// <param name="key"></param>
    /// <returns></returns>
    public async Task<string> setWirelessDirect(string type, string key)
    {
        var data = $"{{\"type\":\"{type}\",\"key\":\"{key}\"}}";
        return await HttpSet("/v1/system/setWirelessDirect", data);
    }

    /// <summary>
    ///     For setting Wireless Network (Wi-Fi). Network connection is switched to wireless (Wi-Fi) by using this API.If no
    ///     parameter is specified, current parameter is used.If set parameter is incomplete, it is possible not to provide
    ///     network avalability
    /// </summary>
    /// <param name="ssid"></param>
    /// <param name="securityType"></param>
    /// <param name="key"></param>
    /// <param name="BoolDHCP"></param>
    /// <param name="ip_address"></param>
    /// <param name="dns_server_1"></param>
    /// <param name="dns_server_2"></param>
    /// <param name="subnet_mask"></param>
    /// <param name="default_gateway"></param>
    /// <returns></returns>
    public async Task<string> setWirelessLan(string ssid, string securityType, string key, string BoolDHCP,
        string ip_address,
        string dns_server_1, string dns_server_2, string subnet_mask = "255.255.255.0",
        string default_gateway = "192.168.1.1")
    {
        var data =
            $"{{\"ssid\":\"{ssid}\",\"type\":\"{securityType}\",\"key\":\"{key}\",\"dhcp\":\"{BoolDHCP.ToLower()}\",\"ip_address\":\"{ip_address}\",\"subnet_mask\":\"{subnet_mask}\",\"default_gateway\":\"{default_gateway}\",\"dns_server_1\":\"{dns_server_1}\",\"dns_server_2\":\"{dns_server_2}\"}}";
        return await HttpSet("/v1/system/setWirelessLan", data);
    }

    /// <summary>
    ///     For setting Zone B volume sync
    /// </summary>
    /// <param name="boolvalue"></param>
    /// <returns></returns>
    public async Task<string> setZoneBVolumeSync(bool boolvalue) => await HttpGet($"/v1/system/setZoneBVolumeSync?enable={boolvalue.ToString().ToLower()}");

    /// <summary>
    ///     For updating Bluetooth (Sink) device list. This API is available only when “bluetooth_tx_setting” is true under
    ///     /system/getFuncStatus. Retrieve update status and list information after finish updating via
    ///     /system/getBluetoothDeviceList.
    /// </summary>
    /// <returns></returns>
    public async Task<string> updateBluetoothDeviceList() => await HttpGet("/v1/system/updateBluetoothDeviceList");

    /// <summary>
    /// For check if new update is available
    /// </summary>
    /// <returns></returns>
    public async Task<string> checkNetworkUpdate() => await HttpGet("/v1/system/checkNetworkUpdate");

    /// <summary>
    /// For check if new update is available through wifi or lan
    /// </summary>
    /// <returns></returns>
    public async Task<string> isNewFirmwareAvailable(string type  = "network") => await HttpGet($"/v1/system/isNewFirmwareAvailable=type{type}");
}