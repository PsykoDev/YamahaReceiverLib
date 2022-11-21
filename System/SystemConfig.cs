using Newtonsoft.Json;
using System.Net;
using System.Xml.Linq;

namespace YamahaReceiverLib.System;

public class SystemConfig : YamahaAV
{
    public string getDeviceInfo()
    {
        return HttpGet("/v1/system/getDeviceInfo");
    }

    public string getFeatures()
    {
        return HttpGet("/v1/system/getFeatures");
    }

    public string getNetworkStatus()
    {
        return HttpGet("/v1/system/getNetworkStatus");
    }

    public string getMacAddressFilter()
    {
        return HttpGet("/v1/system/getMacAddressFilter");
    }

    public string getNetworkStandby()
    {
        return HttpGet("/v1/system/getNetworkStandby");
    }

    public string getBluetoothInfo()
    {
        return HttpGet("/v1/system/getBluetoothInfo");
    }

    public string getBluetoothDeviceList()
    {
        return HttpGet("/v1/system/getBluetoothDeviceList");
    }

    public string updateBluetoothDeviceList()
    {
        return HttpGet("/v1/system/updateBluetoothDeviceList");
    }

    public string connectBluetoothDevice(string address)
    {
        return HttpGet($"/v1/system/connectBluetoothDevice?address={address}");
    }

    public string disconnectBluetoothDevice()
    {
        return HttpGet($"/v1/system/disconnectBluetoothDevice");
    }

    public string getFuncStatus()
    {
        return HttpGet($"/v1/system/getFuncStatus");
    }

    public string getNameText()
    {
        return HttpGet("/v1/system/getNameText");
    }

    public string getLocationInfo()
    {
        return HttpGet("/v1/system/getLocationInfo");
    }

    public string setWiredLan(string BoolDHCP, string ip_address, string dns_server_1, string dns_server_2, string subnet_mask = "255.255.255.0", string default_gateway = "192.168.1.1")
    {
        var data = $"{{\"dhcp\":\"{BoolDHCP.ToLower()}\",\"ip_address\":\"{ip_address}\",\"subnet_mask\":\"{subnet_mask}\",\"default_gateway\":\"{default_gateway}\",\"dns_server_1\":\"{dns_server_1}\",\"dns_server_2\":\"{dns_server_2}\"}}";
        return HttpSet("/v1/system/setWiredLan", data);
    }

    public string setWirelessLan(string ssid, string securityType, string key, string BoolDHCP, string ip_address, string dns_server_1, string dns_server_2, string subnet_mask = "255.255.255.0", string default_gateway = "192.168.1.1")
    {
        var data = $"{{\"ssid\":\"{ssid}\",\"type\":\"{securityType}\",\"key\":\"{key}\",\"dhcp\":\"{BoolDHCP.ToLower()}\",\"ip_address\":\"{ip_address}\",\"subnet_mask\":\"{subnet_mask}\",\"default_gateway\":\"{default_gateway}\",\"dns_server_1\":\"{dns_server_1}\",\"dns_server_2\":\"{dns_server_2}\"}}";
        return HttpSet("/v1/system/setWirelessLan", data);
    }

    public string setWirelessDirect(string type, string key)
    {
        var data = $"{{\"type\":\"{type}\",\"key\":\"{key}\"}}";
        return HttpSet("/v1/system/setWirelessDirect", data);
    }

    public string setIpSettings(string BoolDHCP, string ip_address, string dns_server_1, string dns_server_2, string subnet_mask = "255.255.255.0", string default_gateway = "192.168.1.1")
    {
        var data = $"{{\"dhcp\":{BoolDHCP.ToLower()},\"ip_address\":\"{ip_address}\",\"subnet_mask\":\"{subnet_mask}\",\"default_gateway\":\"{default_gateway}\",\"dns_server_1\":\"{dns_server_1}\",\"dns_server_2\":\"{dns_server_2}\"}}";
        return HttpSet("/v1/system/setIpSettings", data);
    }

    public string setNetworkName(string name)
    {
        var data = $"{{\"name\":\"{name}\"}}";
        return HttpSet("/v1/system/setNetworkName", data);
    }

    public string setAirPlayPin(string pin)
    {
        var data = $"{{\"pin\":\"{pin}\"}}";
        return HttpSet("/v1/system/setAirPlayPin", data);
    }

    public string setMacAddressFilter()
    {
        return HttpSet("/v1/system/setMacAddressFilter");
    }

    public string setNameText(string name)
    {
        return HttpSet($"/v1/system/setNameText?enable={name}");
    }

    public string sendIrCode(string code)
    {
        return HttpGet($"/v1/system/sendIrCode?code={code}");
    }

    public string setHdmiOut1(string boolvalue)
    {
        return HttpGet($"/v1/system/setHdmiOut1?enable={boolvalue.ToLower()}");
    }

    public string setHdmiOut2(string boolvalue)
    {
        return HttpGet($"/v1/system/setHdmiOut2?enable={boolvalue.ToLower()}");
    }

    public enum setdimmer
    {
        auto = -1,
        manual = 0,

    }

    public string SetDimmer(setdimmer enable)
    {
        return HttpGet($"/v1/system/setDimmer?enable={(int)enable}");
    }

    public string setZoneBVolumeSync(string boolvalue)
    {
        return HttpGet($"/v1/system/setZoneBVolumeSync?enable={boolvalue.ToLower()}");
    }

    public string setIrSensor(string boolvalue)
    {
        return HttpGet($"/v1/system/setIrSensor?enable={boolvalue.ToLower()}");
    }

    public string setSpeakerA(string boolvalue)
    {
        return HttpGet($"/v1/system/setSpeakerA?enable={boolvalue.ToLower()}");
    }

    public string setSpeakerB(string boolvalue)
    {
        return HttpGet($"/v1/system/setSpeakerB?enable={boolvalue.ToLower()}");
    }

    public string setAutoPowerStandby(string boolvalue)
    {
        return HttpGet($"/v1/system/setAutoPowerStandby?enable={boolvalue.ToLower()}");
    }

    public string setBluetoothStandby()
    {
        return HttpGet("/v1/system/setBluetoothStandby");
    }

    public string setBluetoothTxSetting()
    {
        return HttpGet("/v1/system/setBluetoothTxSetting");
    }

    public string setNetworkStandby()
    {
        return HttpGet("/v1/system/setNetworkStandby");
    }
}