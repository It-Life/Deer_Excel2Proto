# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: Heroes_Config.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='Heroes_Config.proto',
  package='ConfigData',
  syntax='proto3',
  serialized_options=_b('\n\036com.deer.server.protobuf.proto'),
  serialized_pb=_b('\n\x13Heroes_Config.proto\x12\nConfigData\"k\n\rHeroes_Config\x12\n\n\x02id\x18\x01 \x01(\r\x12\x0c\n\x04name\x18\x02 \x01(\t\x12\x0f\n\x07hero_id\x18\x03 \x01(\r\x12\x15\n\rinit_position\x18\x04 \x03(\t\x12\x18\n\x10hero_prefab_path\x18\x05 \x01(\t\">\n\x12Heroes_Config_Data\x12(\n\x05items\x18\x01 \x03(\x0b\x32\x19.ConfigData.Heroes_ConfigB \n\x1e\x63om.deer.server.protobuf.protob\x06proto3')
)




_HEROES_CONFIG = _descriptor.Descriptor(
  name='Heroes_Config',
  full_name='ConfigData.Heroes_Config',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='id', full_name='ConfigData.Heroes_Config.id', index=0,
      number=1, type=13, cpp_type=3, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='name', full_name='ConfigData.Heroes_Config.name', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='hero_id', full_name='ConfigData.Heroes_Config.hero_id', index=2,
      number=3, type=13, cpp_type=3, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='init_position', full_name='ConfigData.Heroes_Config.init_position', index=3,
      number=4, type=9, cpp_type=9, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='hero_prefab_path', full_name='ConfigData.Heroes_Config.hero_prefab_path', index=4,
      number=5, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=35,
  serialized_end=142,
)


_HEROES_CONFIG_DATA = _descriptor.Descriptor(
  name='Heroes_Config_Data',
  full_name='ConfigData.Heroes_Config_Data',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='items', full_name='ConfigData.Heroes_Config_Data.items', index=0,
      number=1, type=11, cpp_type=10, label=3,
      has_default_value=False, default_value=[],
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      serialized_options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  serialized_options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=144,
  serialized_end=206,
)

_HEROES_CONFIG_DATA.fields_by_name['items'].message_type = _HEROES_CONFIG
DESCRIPTOR.message_types_by_name['Heroes_Config'] = _HEROES_CONFIG
DESCRIPTOR.message_types_by_name['Heroes_Config_Data'] = _HEROES_CONFIG_DATA
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

Heroes_Config = _reflection.GeneratedProtocolMessageType('Heroes_Config', (_message.Message,), dict(
  DESCRIPTOR = _HEROES_CONFIG,
  __module__ = 'Heroes_Config_pb2'
  # @@protoc_insertion_point(class_scope:ConfigData.Heroes_Config)
  ))
_sym_db.RegisterMessage(Heroes_Config)

Heroes_Config_Data = _reflection.GeneratedProtocolMessageType('Heroes_Config_Data', (_message.Message,), dict(
  DESCRIPTOR = _HEROES_CONFIG_DATA,
  __module__ = 'Heroes_Config_pb2'
  # @@protoc_insertion_point(class_scope:ConfigData.Heroes_Config_Data)
  ))
_sym_db.RegisterMessage(Heroes_Config_Data)


DESCRIPTOR._options = None
# @@protoc_insertion_point(module_scope)
