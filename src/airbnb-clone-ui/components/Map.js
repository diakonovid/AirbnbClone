import { useState } from 'react';
import ReactMapGL, {Marker, Popup, NavigationControl} from 'react-map-gl';
import getCenter from 'geolib/es/getCenter';
import MapInfoCard from './MapInfoCard';

function Map({searchResult}) {

    const navControlStyle= {
        right: 10,
        top: 10
    };

    const [selectedLocation, setSelectedLocation] = useState({});

    const coordinates = searchResult.map((result) => ({
        latitude: result.lat,
        longitude: result.long
    }));

    const center = getCenter(coordinates);

    const [viewport, setViewport] = useState({
        width: "100%",
        height: "91vh",
        zoom: 11,
        latitude: center.latitude,
        longitude: center.longitude
      });

    return (
        <ReactMapGL
            mapStyle={process.env.NEXT_PUBLIC_MAPBOX_STYLE}
            mapboxApiAccessToken={process.env.NEXT_PUBLIC_MAPBOX_KEY}
            {...viewport}
            onViewportChange={(nextVieport) => setViewport(nextVieport)}           
        >
            <NavigationControl style={navControlStyle} onViewportChange={(nextVieport) => setViewport(nextVieport)}/>
            {searchResult.map((result) => (
                <div key={result.lat}>
                    <Marker 
                        longitude={result.long}
                        latitude={result.lat}
                        offsetTop={-10}
                        offsetLeft={-20} 
                    >
                        <p 
                            role="img"
                            onClick={() => setSelectedLocation(result)}
                            aria-label="push-pin"
                            className="px-2 border rounded-full hover:shadow-lg 
                            active:scale-95 bg-white active:bg-gray-100 transition transform
                            duration-100 ease-out cursor-pointer"
                        >
                            {result.total}
                        </p>
                    </Marker>

                    {selectedLocation?.long === result.long ? (
                        <Popup
                            onClose={() => setSelectedLocation({})}
                            closeOnClick={true}
                            closeButton={false}
                            latitude={result.lat}
                            longitude={result.long}
                            className="z-50"
                        >
                            <MapInfoCard {...result}/>
                        </Popup>
                    ) : (false)}
                </div>
            ))}
        </ReactMapGL>
    )
}

export default Map
