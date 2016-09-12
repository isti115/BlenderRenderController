import os
import json
import bpy
from bpy import context
from bpy import ops

blendPath = bpy.context.blend_data.filepath;
projName  = bpy.path.display_name_from_filepath( blendPath );

outputPath = bpy.data.scenes["Scene"].render.filepath

bpy.ops.sound.mixdown( filepath=outputPath + "\\" + projName + ".ac3",
		               container='AC3',
					   codec='AC3',
					   accuracy=1024,
					   bitrate=512,
					   format="F32",
					   split_channels=False);

