import os
import json
import bpy
from bpy import context
from bpy import ops

blendPath = bpy.context.blend_data.filepath;
projName  = bpy.path.display_name_from_filepath( blendPath );

startFrame = bpy.data.scenes["Scene"].frame_start
endFrame   = bpy.data.scenes["Scene"].frame_end
outputPath = bpy.data.scenes["Scene"].render.filepath

#print( "Proj Name: %s\n" % (projName) )
#print( "Start: %s\n" % (startFrame) )
#print( "end: %s\n" % (endFrame) )

data = { 'ProjectName': projName, 'StartFrame': startFrame, 'EndFrame': endFrame, 'OutputDirectory': outputPath };

jsonData = json.dumps(data, indent=4, skipkeys=True, sort_keys=True);

print(jsonData);

