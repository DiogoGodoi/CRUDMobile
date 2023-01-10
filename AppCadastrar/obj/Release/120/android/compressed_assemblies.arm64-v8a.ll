; ModuleID = 'obj\Release\120\android\compressed_assemblies.arm64-v8a.ll'
source_filename = "obj\Release\120\android\compressed_assemblies.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [137728 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [4608 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [5120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [9216 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [165888 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [1187328 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [121856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [635904 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [20856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [100352 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [831488 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [166512 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [62464 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [212992 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [35840 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [18024 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [25984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [7680 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [1047552 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [830976 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [4608 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [6144 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [6144 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [317952 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [142336 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [8704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_26 = internal global [40960 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_27 = internal global [152576 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_28 = internal global [14848 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_29 = internal global [15872 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_30 = internal global [16896 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_31 = internal global [36352 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_32 = internal global [12800 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_33 = internal global [24576 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_34 = internal global [18072 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_35 = internal global [4096 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_36 = internal global [2050560 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [37 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 137728, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([137728 x i8], [137728 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([4608 x i8], [4608 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([5120 x i8], [5120 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 9216, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([9216 x i8], [9216 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 165888, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([165888 x i8], [165888 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 1187328, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1187328 x i8], [1187328 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 121856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([121856 x i8], [121856 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 635904, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([635904 x i8], [635904 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 20856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([20856 x i8], [20856 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 100352, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([100352 x i8], [100352 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 831488, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([831488 x i8], [831488 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 166512, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([166512 x i8], [166512 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 62464, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([62464 x i8], [62464 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 212992, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([212992 x i8], [212992 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 35840, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([35840 x i8], [35840 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 18024, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18024 x i8], [18024 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 25984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([25984 x i8], [25984 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 7680, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([7680 x i8], [7680 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 1047552, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1047552 x i8], [1047552 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 830976, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([830976 x i8], [830976 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([4608 x i8], [4608 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6144 x i8], [6144 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6144 x i8], [6144 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 317952, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([317952 x i8], [317952 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 142336, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([142336 x i8], [142336 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 8704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([8704 x i8], [8704 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}, 
	; 26
	%struct.CompressedAssemblyDescriptor {
		i32 40960, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([40960 x i8], [40960 x i8]* @__CompressedAssemblyDescriptor_data_26, i32 0, i32 0); data
	}, 
	; 27
	%struct.CompressedAssemblyDescriptor {
		i32 152576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([152576 x i8], [152576 x i8]* @__CompressedAssemblyDescriptor_data_27, i32 0, i32 0); data
	}, 
	; 28
	%struct.CompressedAssemblyDescriptor {
		i32 14848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14848 x i8], [14848 x i8]* @__CompressedAssemblyDescriptor_data_28, i32 0, i32 0); data
	}, 
	; 29
	%struct.CompressedAssemblyDescriptor {
		i32 15872, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15872 x i8], [15872 x i8]* @__CompressedAssemblyDescriptor_data_29, i32 0, i32 0); data
	}, 
	; 30
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([16896 x i8], [16896 x i8]* @__CompressedAssemblyDescriptor_data_30, i32 0, i32 0); data
	}, 
	; 31
	%struct.CompressedAssemblyDescriptor {
		i32 36352, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36352 x i8], [36352 x i8]* @__CompressedAssemblyDescriptor_data_31, i32 0, i32 0); data
	}, 
	; 32
	%struct.CompressedAssemblyDescriptor {
		i32 12800, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([12800 x i8], [12800 x i8]* @__CompressedAssemblyDescriptor_data_32, i32 0, i32 0); data
	}, 
	; 33
	%struct.CompressedAssemblyDescriptor {
		i32 24576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([24576 x i8], [24576 x i8]* @__CompressedAssemblyDescriptor_data_33, i32 0, i32 0); data
	}, 
	; 34
	%struct.CompressedAssemblyDescriptor {
		i32 18072, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18072 x i8], [18072 x i8]* @__CompressedAssemblyDescriptor_data_34, i32 0, i32 0); data
	}, 
	; 35
	%struct.CompressedAssemblyDescriptor {
		i32 4096, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([4096 x i8], [4096 x i8]* @__CompressedAssemblyDescriptor_data_35, i32 0, i32 0); data
	}, 
	; 36
	%struct.CompressedAssemblyDescriptor {
		i32 2050560, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2050560 x i8], [2050560 x i8]* @__CompressedAssemblyDescriptor_data_36, i32 0, i32 0); data
	}
], align 8; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 37, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([37 x %struct.CompressedAssemblyDescriptor], [37 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 8


!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-3 @ 030cd63c06d95a6b0d0f563fe9b9d537f84cb84b"}
