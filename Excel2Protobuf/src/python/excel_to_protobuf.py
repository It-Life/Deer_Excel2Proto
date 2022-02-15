##
# @file:   excel_to_protobuf.py
# @author:  Triniti Interactive Limited
# Copyright (c) Triniti Interactive Limited All rights reserved.
#
# This code is licensed under the MIT License (MIT).
# THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
# ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
# IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
# PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
# brief:  export excel to protobuf
##
# 确保所有表格的第一列都是唯一索引
#
# parameters
# -i --input_path input folder which contains excel files to convert.
#       This script converts all excel file from that folder
# -d --data_out folder where serialized binary protobuf file exported
# -n --name_space specific the namespace of the exported code
# -c --csharp_out folder where auto generated C# script file(from protoc.exe) exported
# -s --server folder where auto generated server script file(from protoc.exe) exported
# -l --Server-side programm language eg.(cpp|csharp|java|go|js|objc|php|python|ruby )
# -p --java out package name 
##
from excel_interpreter import WorkbookInterperter
from excel_parser import WorkbookParser
from Utils import *

import sys
import getopt
import time

temp_dir = "./_temp"
temp_proto_files_path = "%s/proto_files" % temp_dir
temp_proto_data_path = "%s/proto_data" % temp_dir
temp_autogenerated_scripts_path = "%s/autogenerated_scripts" % temp_dir


def safe_create_temp_dir():
    rmdir(temp_dir)
    makedir(temp_proto_files_path)
    makedir(temp_proto_data_path)
    makedir(temp_autogenerated_scripts_path)

def main():
    print(os.getcwd())
    excels_dir = None
    namespace = None
    data_out = None
    csharp_out = None
    server_out = None
    language = None
    package_name = None

    try:
        opts, args = getopt.getopt(sys.argv[1:], "i:n:d:c:s:l:p:-v", [
                                   "input_path=", "namespace=", "data_out=", "csharp_out=", "server_out=", "language=", "packagename="])
        for o, a in opts:
            if o in ("-i", "--input_path"):
                excels_dir = a
            elif o in ("-n", "--namespace"):
                namespace = a
            elif o in ("-d", "--data_out"):
                data_out = a
            elif o in ("-c", "--csharp_out"):
                csharp_out = a
            elif o in ("-s", "--server_out"):
                server_out = a
            elif o in ("-l", "--language"):
                language = a
            elif o in ("-p", "--packagename"):
                package_name = a
    except Exception as e:
        logError("argv error:%s" % e)

    # excels_dir = "D:/Working/DeerGameFramework/trunk/xConfig/ConfigFiles(excel)"
    # namespace = "ConfigData"
    # data_out = "D:/Working/DeerGameFramework/xConfig/Excel2Protobuf/test/client/data"
    # csharp_out = "D:/Working/DeerGameFramework/xConfig/Excel2Protobuf/test/client/scripts"
    # server_out = "D:/Working/DeerGameFramework/xConfig/Excel2Protobuf/test/server/class"
    # language = "java"
    # package_name = "com.trinitigames.server.conf.auto"

    if excels_dir is None:
        logError("-i --input_path excels source folder not set properly")
    # if data_out is None:
    print("")
    print("package_name:" + package_name)
    print("namespace:" + namespace)
    print("Excle Path:" + excels_dir)
    print("Data Path:" + data_out)
    print("csharp_out Path:" + csharp_out)
    print("server_out Path:" + server_out)
    print("server language:" + language)
    print("")
    start_time = time.time()
    # temp files dir
    safe_create_temp_dir()
    listfile = []
    get_filelist(excels_dir,listfile)
    excel_files2_convert = []
    for filepath in listfile:
        tempfile = os.path.basename(filepath)
        if os.path.splitext(tempfile)[1] == ".xlsx" and not tempfile.startswith('~$'):
            tempfilepath = filepath.replace('\\','/')
            excel_files2_convert.append(tempfilepath)
    # for root, dirs, files in os.walk(excels_dir):
    #     # if root == './':
    #         for file in files:
    #             if os.path.splitext(file)[1] == ".xlsx" and not file.startswith('~$'):
    #                 folder = excels_dir + "/" if excels_dir != './' else ''
    #                 excel_files2_convert.append(folder + file)

    binary_output_files_summary = ""
    for file in excel_files2_convert:
        excel_interpreter, excel_serializer = export_excel2protobuff(
            file, namespace, data_out, csharp_out, server_out, language, package_name)
        binary_output_files_summary += excel_serializer._output_file_name + "\n"

    # save summary files
    file = open(data_out+"/summary.txt", 'w+')
    file.write(binary_output_files_summary)
    file.close()
    print("time eplased %.2f" % (time.time() - start_time))


def export_excel2protobuff(xls_file_path, namespace, data_out, csharp_out, server_out, language, package_name):
    excel_interpreter = WorkbookInterperter(
        xls_file_path, namespace, package_name)
    excel_interpreter.interpreter()
    excel_interpreter.save(
        temp_proto_files_path, temp_autogenerated_scripts_path, csharp_out, server_out, language)

    # if data_out is not None:
    excel_serializer = WorkbookParser(
        xls_file_path, temp_autogenerated_scripts_path)
    excel_serializer.serialize(temp_proto_data_path, data_out)
    return excel_interpreter, excel_serializer


# 参数1 输入excel文件路径 参数2 导出目录
if __name__ == '__main__':
    main()
