# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: DB_Login.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
from google.protobuf import descriptor_pb2
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()


import Common_Base_pb2 as Common__Base__pb2
import DB_Base_pb2 as DB__Base__pb2


DESCRIPTOR = _descriptor.FileDescriptor(
  name='DB_Login.proto',
  package='PDB_Login',
  syntax='proto3',
  serialized_pb=_b('\n\x0e\x44\x42_Login.proto\x12\tPDB_Login\x1a\x11\x43ommon_Base.proto\x1a\rDB_Base.proto\"\n\n\x08Point_Fbb\x06proto3')
  ,
  dependencies=[Common__Base__pb2.DESCRIPTOR,DB__Base__pb2.DESCRIPTOR,])




_POINT_FB = _descriptor.Descriptor(
  name='Point_Fb',
  full_name='PDB_Login.Point_Fb',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=63,
  serialized_end=73,
)

DESCRIPTOR.message_types_by_name['Point_Fb'] = _POINT_FB
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

Point_Fb = _reflection.GeneratedProtocolMessageType('Point_Fb', (_message.Message,), dict(
  DESCRIPTOR = _POINT_FB,
  __module__ = 'DB_Login_pb2'
  # @@protoc_insertion_point(class_scope:PDB_Login.Point_Fb)
  ))
_sym_db.RegisterMessage(Point_Fb)


# @@protoc_insertion_point(module_scope)
