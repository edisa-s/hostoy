import { MapContainer, Popup, TileLayer, Marker } from "react-leaflet";
import "leaflet/dist/leaflet.css";

type Props = {
  position: [number, number];
  department: string;
};

export default function MapComponent({ position, department }: Props) {
  return (
    <MapContainer
      center={position}
      zoom={13}
      scrollWheelZoom={false}
      style={{ height: "100%" }}
    >
      <TileLayer url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png" />
      <Marker position={position}>
        <Popup>{department}</Popup>
      </Marker>
    </MapContainer>
  );
}
