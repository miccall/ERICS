Shader "miccall/GP1"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_MainColor("mainColor",Color ) = (1,1,1,1)
		_RADIUSBUCE("_RADIUSBUCE",Range(0,0.5))=0.2
		_outline("outline" , float ) = 1.2 
		_Color ("outcolor",Color) = (1,1,1,1)
	}
	
	SubShader
	{
	
        // 模板剔除
		Pass
		{
            // No culling or depth
            ZWrite off 
            Stencil {
                Ref 2
                Comp Always
                Pass REPLACE
            }
        
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			fixed4 _Color ;
			sampler2D _MainTex ;

			fixed4 frag (v2f i) : SV_Target
			{
			    float4 tex = tex2D(_MainTex,i.uv);
				return tex;
			}
			ENDCG
		}
		 
	}
}
