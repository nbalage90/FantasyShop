// eslint-disable-next-line react/prop-types
export default function Button({ title, className, onClick }) {
  return (
    <button
      className={className}
      onClick={onClick}
    >
      {title}
    </button>
  );
}
